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
    public partial class Params : Form
    {
        public delegate string ChangeColorButton();

        public Params()
        {
            InitializeComponent();

        }

        public void Params_Shown(object sender, EventArgs e)
        {
            DataGridParams.ThemeStyle.HeaderStyle.BackColor = Main.BTNColor;
            for (int i = 0; i < 10; i++)
            {
                DataGridParams.Rows.Add(i,"dgd","dgfes");
            }
        }

    }
}
