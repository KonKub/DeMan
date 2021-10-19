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
    public partial class Settings : Form
    {
        public delegate string ChangeColorButton();

        public Settings()
        {
            InitializeComponent();

        }

        public void Settings_Shown(object sender, EventArgs e)
        {
            DataGridSetting.ThemeStyle.HeaderStyle.BackColor = Main.BTNColor;
            DataGridSetting.ThemeStyle.AlternatingRowsStyle.BackColor = Main.TableRowColor;
            for (int i = 0; i < 50; i++)
            {
                DataGridSetting.Rows.Add(i,"dgd","dgfes");
            }
        }

        private void DataGridSettings_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DataGridSetting.Height < this.Height - 10) DataGridSetting.Height = DataGridSetting.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DataGridSetting.ColumnHeadersHeight+5;
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            if (DataGridSetting.Height < this.Height - 10) DataGridSetting.Height = DataGridSetting.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DataGridSetting.ColumnHeadersHeight + 5;
        }
    }
}
