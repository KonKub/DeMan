using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeMan
{
    class USB_CAN_Adapter
    {
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_init(byte[] parm);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_register(ref int handle, int vid, int pid, int mi, int reportId, int reportSize, int reportType);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_deregister(ref int handle);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_write(int handle, byte[] buffer, int bytesToWrite, ref int bytesWritten);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_read(int handle, byte[] buffer, int bytesToRead, ref int bytesRead);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_find(int handle);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_identify(int handle, byte[] buffer, int bufferSize, ref int bytesProcessed);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_info(byte[] buffer1, int bufferSize1, byte[] buffer2, int bufferSize2);

        private const int TIMER_INTERVAL = 50;
        private const int TMP_BUFFER_SIZE = 1000;

        private const int AHID_OK = 0;
        private const int AHID_ERROR = -1;

        private bool Connected = false;
        private int outputHandle;
        private int inputHandle;

        private Timer timerRead;
        private Timer timerFind;

        byte[] CANMsg = new byte[12];
        byte CANMsgCursor=0;
        byte HeaderExpected = 7;
        bool HeaderFound = false;

        public delegate void ReadHandler(byte[] AData);
        public event ReadHandler ReadNotification;
        public delegate void ReadCANMsg(byte[] AData);
        public event ReadCANMsg ReadCAN;

        public USB_CAN_Adapter()
        {
            timerRead = new Timer();
            timerRead.Interval = TIMER_INTERVAL;    //интервал чтения данных
            timerRead.Tick += new EventHandler(timerReadCallback);
            timerRead.Start();

            timerFind = new Timer();
            timerFind.Interval = 1000;              //1000 - поиск каждую секунду
            timerFind.Tick += new EventHandler(timerFindCallback);
            timerFind.Start();
        }

        private void timerReadCallback(object sender, EventArgs e)
        {
            read();
        }

        private void timerFindCallback(object sender, EventArgs e)
        {
            find();
        }

        public void connect()
        {
            try
            {
                if (!Connected)
                {
                    byte[] parm = System.Text.Encoding.ASCII.GetBytes("\0");

                    if (AHID_ERROR == AHid_init(parm))
                    {
                        byte[] buffer1 = new byte[TMP_BUFFER_SIZE];
                        byte[] buffer2 = new byte[TMP_BUFFER_SIZE];

                        AHid_info(buffer1, TMP_BUFFER_SIZE, buffer2, TMP_BUFFER_SIZE);
                    }

                    AHid_register(ref outputHandle, 0x0483, 0x5750, -1, 4, 64, 1);
                    AHid_register(ref  inputHandle, 0x0483, 0x5750, -1, 0, 64, 0);

                    find();

                    Connected = true;
                }
                else
                {
                    AHid_deregister(ref outputHandle);
                    AHid_deregister(ref inputHandle);

                    Connected = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("AHid.dll not found!","DLL error", MessageBoxButtons.OK);

                //Application.Exit();
            }
        }
        private void setGUID()
        {
            int bytesProcessed = 0;
            byte[] path = new byte[TMP_BUFFER_SIZE];

            if (AHID_OK == AHid_identify(outputHandle, path, TMP_BUFFER_SIZE, ref bytesProcessed))
            {
                //textGUID.Text = Encoding.Default.GetString(path);
            }
        }

        protected bool find()
        {
            bool result = false;

            if (AHid_find(outputHandle)== AHID_OK && AHid_find(inputHandle)==AHID_OK)
            {
                setGUID();

                //textStatus.Text = "ATTACHED";

                result = true;
            }
            else
            {
                //textStatus.Text = "REMOVED";
            }

            return result;
        }

        private void read()
        {
            int bytesRead = 0;
            byte[] buffer = new byte[64];

            for (int i = 0; i < TIMER_INTERVAL; i++)
            {
                AHid_read(inputHandle, buffer, 64, ref bytesRead);

                if (bytesRead != 0) //считаны какие-то данные
                {
                    ReadNotification?.Invoke(buffer);
                    //поиск CAN-сообщений
                    for (int j = 0; j < buffer.Length; j++)
                    {
                        if (!HeaderFound) //ищем заголовок
                        {
                            if (buffer[j] == 101)
                            {
                                HeaderFound = true;
                                CANMsgCursor = 0;
                                continue;
                            }
                        }
                        else  //заголовок найден
                        {
                            CANMsg[CANMsgCursor] = buffer[j];
                            CANMsgCursor++;
                            if (CANMsgCursor >= CANMsg.Length)
                            {
                                ReadCAN?.Invoke(CANMsg);
                                HeaderFound = false;
                            }
                        }
                    }
                }
            }
        }

        public void write(byte[] AData)
        {
            int bytesWritten = 0;

            if (AHid_write(outputHandle, AData, 63, ref bytesWritten) == AHID_OK)
            {
                //textOutputCounter.Text = outputCounter.ToString();
            }
        }
    }
}
