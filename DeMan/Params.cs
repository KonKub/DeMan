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
            /* if (Main.BTNColor == ColorTranslator.FromHtml(ColorChoice.ColorList[0])) {

                 DataGridParams.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
             }
             if (Main.BTNColor == ColorTranslator.FromHtml(ColorChoice.ColorList[1]))
             {
                 DataGridParams.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
             }
             if (Main.BTNColor == ColorTranslator.FromHtml(ColorChoice.ColorList[2]))
             {
                 DataGridParams.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo;
             }
             if (Main.BTNColor == ColorTranslator.FromHtml(ColorChoice.ColorList[3]))
             {
                 DataGridParams.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.DeepPurple;
             }
            */
            DataGridParams.ThemeStyle.HeaderStyle.BackColor = Main.BTNColor;
        }

    }
}
