using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMan
{
    public partial class USB : Form
    {
        public USB()
        {
            InitializeComponent();

            USBCAN = new USB_CAN_Adapter();
            USBCAN.ReadNotification += USBCANReadData;   // Добавляем обработчик для события ReadNotification
            USBCAN.ReadCAN += USBCANReadMsg;             // Добавляем обработчик для события ReadCAN

            USBCAN.connect();
        }

        private USB_CAN_Adapter USBCAN;

        private void USBCANReadData(byte[] AData) //обработчик для события USB-CAN ReadNotification
        {
            string s = "";
            for (int i = 0; i < AData.Length; i++)
                s = s + String.Format("{0,4}", AData[i]);
            label1.Text = s;
            //LogBox.Text += s + Environment.NewLine;
        }
        private void USBCANReadMsg(byte[] AData) //обработчик для события USB-CAN ReadNotification
        {
            string s = "";
            for (int i = 0; i < AData.Length; i++)
                s = s + String.Format("{0,4}", AData[i]);
            LogBox.Text += s + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                              //  команда|-----ExtID------|------------Data[8]-----------------
            byte[] w = new byte[] { 0, 101, 0, 100, 67, 240, 0, 18, 255, 255, 255, 255, 255, 255 };
            USBCAN.write(w);
        }
    }
}
