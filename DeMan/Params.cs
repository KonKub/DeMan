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
        public Params()
        {
            InitializeComponent();
        }

        private void Params_Shown(object sender, EventArgs e)
        {
            DataGridParams.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(48, 48, 54);
            DataGridParams.ThemeStyle.AlternatingRowsStyle.BackColor = Main.TableRowColor;
        }
    }
}
