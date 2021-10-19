using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMan
{
    class ProtocolCAN
    {
        public struct TMessage
        {
            public int PGN;
            public byte RecieverType;
            public byte RecieverAddr;
            public byte TransmitterType;
            public byte TransmitterAddr;

            public byte[] Data;
        }
        private TMessage USBCANMessage = new TMessage() { Data = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 } };
        private TMessage VSCANMessage = new TMessage() { Data = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 } };

        private USB_CAN_Adapter USBCAN;
        private VScom VSCCAN;

        public delegate void CANMsg(TMessage AMessage);
        public event CANMsg ReadCAN;

        public ProtocolCAN()
        {
            USBCAN = new USB_CAN_Adapter();
            USBCAN.ReadNotification += USBCANReadData;                         // Добавляем обработчик для события ReadNotification
            USBCAN.ReadCAN += USBCANReadMsg;                                   // Добавляем обработчик для события ReadCAN
            USBCAN.connect();

            VSCCAN = new VScom();
            VSCCAN.ReadCAN += VSCANReadMsg;                                    // Добавляем обработчик для события ReadCAN
        }

        private void USBCANReadData(byte[] AData)                              //обработчик для события USB-CAN ReadNotification
        {
            //string s = "";
            //for (int i = 0; i < AData.Length; i++) s = s + String.Format("{0,4}", AData[i]);
            //label1.Text = s;
            //LogBox.Text += s + Environment.NewLine;
        }

        private void USBCANReadMsg(byte[] AData)                               //обработчик для события USB-CAN ReadNotification
        {
            //string s = "";
            if (AData.Length > 3) 
            {
                int ID = (AData[0] << 24) + (AData[1] << 16) + (AData[2] << 8) + AData[3];
                USBCANMessage.PGN = (byte)(ID>>20);
                USBCANMessage.RecieverType = (byte)((ID>>13) & 0b0111_1111);
                USBCANMessage.RecieverAddr = (byte)((ID>>10) & 0b0000_0111);
                USBCANMessage.TransmitterType = (byte)((ID >> 3) & 0b0111_1111);
                USBCANMessage.TransmitterAddr = (byte)(ID & 0b0000_0111);
            }
            for (int i = 4; i < AData.Length; i++)
                USBCANMessage.Data[i - 4] = AData[i];

            ReadCAN?.Invoke(USBCANMessage);
        }

        private void VSCANReadMsg(VSCAN_MSG[] AMsg, UInt32 ARead)              //обработчик для события VScom ReadNotification
        {
            for (int i = 0; i < ARead; i++)
            {
                //string s = "";
                //s = s + String.Format("{0,10}, {1,3}, {2,3}, {3,3}, {4,3}, {5,3}, {6,3}, {7,3}, {8,3}",
                //AMsg[i].Id,
                //AMsg[i].Data[0], AMsg[i].Data[1], AMsg[i].Data[2], AMsg[i].Data[3],
                //AMsg[i].Data[4], AMsg[i].Data[5], AMsg[i].Data[6], AMsg[i].Data[7]);
                //LogBox.Text += s + Environment.NewLine;
                VSCANMessage.PGN = (byte)(AMsg[i].Id >> 20);
                VSCANMessage.RecieverType = (byte)((AMsg[i].Id >> 13) & 0b0111_1111);
                VSCANMessage.RecieverAddr = (byte)((AMsg[i].Id >> 10) & 0b0000_0111);
                VSCANMessage.TransmitterType = (byte)((AMsg[i].Id >> 3) & 0b0111_1111);
                VSCANMessage.TransmitterAddr = (byte)(AMsg[i].Id & 0b0000_0111);
                for (int j = 0; j < 7; j++)
                    VSCANMessage.Data[j] = AMsg[i].Data[j];

                ReadCAN?.Invoke(VSCANMessage);
            }
        }
    }
}
