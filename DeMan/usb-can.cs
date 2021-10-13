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

        const int TIMER_INTERVAL = 50;
        const int TMP_BUFFER_SIZE = 1000;

        const int MAX_REPORT_SIZE = 64;
        const int AHID_REPORT_TYPE_INPUT = 0;
        const int AHID_REPORT_TYPE_OUTPUT = 1;
        const int AHID_OK = 0;
        const int AHID_ERROR = -1;

        static int findInterval;

        bool Connected = false;
        int interfaceID;
        int outputHandle;
        int outputReportID;
        int outputReportSize;
        int inputHandle;
        int inputReportID;
        int inputReportSize;

        Timer timer;

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
            timer = new Timer();

            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timerCallback);
            timer.Start();

            interfaceID = -1;
            outputReportID = 4;
            outputReportSize = 64;
            inputReportID = 0;
            inputReportSize = 64;
        }

        private void timerCallback(object sender, EventArgs e)
        {
            read();
            if ((findInterval++ % 10) == 0) find();
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

                    AHid_register(ref outputHandle, 0x0483, 0x5750, interfaceID, outputReportID, outputReportSize, AHID_REPORT_TYPE_OUTPUT);
                    AHid_register(ref  inputHandle, 0x0483, 0x5750, interfaceID, inputReportID, inputReportSize, AHID_REPORT_TYPE_INPUT);

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

            if (AHID_OK == AHid_find(outputHandle) &&
                AHID_OK == AHid_find(inputHandle))
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
            byte[] buffer = new byte[MAX_REPORT_SIZE];

            for (int i = 0; i < TIMER_INTERVAL; i++)
            {
                AHid_read(inputHandle, buffer, inputReportSize, ref bytesRead);

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
