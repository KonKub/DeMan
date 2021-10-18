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

            Parameters Par = new Parameters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                              //   команда|-----ExtID------|------------Data[8]-----------------
            byte[] w = new byte[] { 0, 101, 0, 100, 67, 240, 0, 18, 255, 255, 255, 255, 255, 255 };
            //USBCAN.write(w);
        }
    }
}
