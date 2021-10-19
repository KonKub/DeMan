using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMan
{
    class VScom
    {
        private const int TIMER_INTERVAL = 50;
        private const byte ArrSize = 100;
        VSCAN_MSG[] msgs = new VSCAN_MSG[ArrSize];
        VSCAN CanDevice = new VSCAN();
        UInt32 MsgSentCnt = 0;
        UInt32 MsgReadCnt = 0;
        VSCAN_API_VERSION api_ver = new VSCAN_API_VERSION();
        byte Flags = 0x0;

        private Timer timerRead;

        public delegate void ReadCANMsg(VSCAN_MSG[] AMsg, UInt32 ARead);
        public event ReadCANMsg ReadCAN;

        public VScom()
        {
            // set debugging options
            CanDevice.SetDebug(VSCAN.VSCAN_DEBUG_NONE);
            CanDevice.SetDebugMode(VSCAN.VSCAN_DEBUG_MODE_FILE);

            // open CAN channel: please specify the name of your device according to User Manual
            CanDevice.Open(VSCAN.VSCAN_FIRST_FOUND, VSCAN.VSCAN_MODE_NORMAL);

            // set some options
            CanDevice.SetSpeed(VSCAN.VSCAN_SPEED_250K);
            CanDevice.SetTimestamp(VSCAN.VSCAN_TIMESTAMP_ON);
            CanDevice.SetBlockingRead(VSCAN.VSCAN_IOCTL_ON);

            // get API version
            CanDevice.GetApiVersion(ref api_ver);
            //Console.WriteLine("API version: " + api_ver.Major + "." + api_ver.Minor + "." + api_ver.SubMinor);

            timerRead = new Timer();
            timerRead.Interval = TIMER_INTERVAL;    //интервал чтения данных
            timerRead.Tick += new EventHandler(timerReadCallback);
            timerRead.Start();
        }

        ~VScom()
        {
            CanDevice.Close();
        }

            private void timerReadCallback(object sender, EventArgs e)
        {
            read();
        }

        public void write(VSCAN_MSG[] AMsg)
        {
            CanDevice.Write(AMsg, 1, ref MsgSentCnt);
            CanDevice.Flush(); // send immediately 
        }

        public void read()
        {
            // read CAN frames
            do
            {
                CanDevice.Read(ref msgs, ArrSize, ref MsgReadCnt);
                ReadCAN?.Invoke(msgs, MsgReadCnt);

                for (int i = 0; i < MsgReadCnt; i++)
                {
                    //Console.WriteLine("CAN frame " + i+" ID: " + msgs[i].Id+" Size: " + msgs[i].Size);
                    //Console.Write("Data: ");
                    //for (int j = 0; j < msgs[i].Size; j++)  Console.Write(msgs[i].Data[j] + " ");

                    //if ((msgs[i].Flags & VSCAN.VSCAN_FLAGS_STANDARD) != 0) Console.WriteLine("VSCAN_FLAGS_STANDARD");
                    //if ((msgs[i].Flags & VSCAN.VSCAN_FLAGS_EXTENDED) != 0) Console.WriteLine("VSCAN_FLAGS_EXTENDED");
                    //if ((msgs[i].Flags & VSCAN.VSCAN_FLAGS_REMOTE) != 0) Console.WriteLine("VSCAN_FLAGS_REMOTE");
                    //if ((msgs[i].Flags & VSCAN.VSCAN_FLAGS_TIMESTAMP) != 0) Console.WriteLine("VSCAN_FLAGS_TIMESTAMP");
                    //Console.WriteLine("TS: " + msgs[i].TimeStamp);
                }

                // get extended status and error flags
                //CanDevice.GetFlags(ref Flags);
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_API_RX_FIFO_FULL) > 0) Console.WriteLine("API RX FIFO full");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_ARBIT_LOST) > 0) Console.WriteLine("Arbitration lost");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_BUS_ERROR) > 0) Console.WriteLine("Bus error");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_DATA_OVERRUN) > 0) Console.WriteLine("Data overrun");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_ERR_PASSIVE) > 0) Console.WriteLine("Passive error");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_ERR_WARNING) > 0) Console.WriteLine("Error warning");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_RX_FIFO_FULL) > 0) Console.WriteLine("RX FIFO full");
                //if ((Flags & VSCAN.VSCAN_IOCTL_FLAG_TX_FIFO_FULL) > 0) Console.WriteLine("TX FIFO full");
            } while (MsgReadCnt <= 0);
        }
    }
}
