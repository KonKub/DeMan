
namespace DeMan
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plbtn = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnWriteRAM = new FontAwesome.Sharp.IconButton();
            this.brnRead = new FontAwesome.Sharp.IconButton();
            this.plTable = new System.Windows.Forms.Panel();
            this.DataGridSetting = new Guna.UI.WinForms.GunaDataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Параметр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plbtn.SuspendLayout();
            this.plTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // plbtn
            // 
            this.plbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.plbtn.Controls.Add(this.btnSave);
            this.plbtn.Controls.Add(this.btnWriteRAM);
            this.plbtn.Controls.Add(this.brnRead);
            this.plbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plbtn.Location = new System.Drawing.Point(0, 0);
            this.plbtn.Name = "plbtn";
            this.plbtn.Size = new System.Drawing.Size(733, 30);
            this.plbtn.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(402, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Tag = "Считать";
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnWriteRAM
            // 
            this.btnWriteRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.btnWriteRAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWriteRAM.FlatAppearance.BorderSize = 0;
            this.btnWriteRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteRAM.ForeColor = System.Drawing.Color.White;
            this.btnWriteRAM.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnWriteRAM.IconColor = System.Drawing.Color.White;
            this.btnWriteRAM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWriteRAM.IconSize = 40;
            this.btnWriteRAM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteRAM.Location = new System.Drawing.Point(201, 0);
            this.btnWriteRAM.Name = "btnWriteRAM";
            this.btnWriteRAM.Size = new System.Drawing.Size(201, 30);
            this.btnWriteRAM.TabIndex = 1;
            this.btnWriteRAM.Tag = "Записать в ОЗУ";
            this.btnWriteRAM.Text = "Записать в ОЗУ";
            this.btnWriteRAM.UseVisualStyleBackColor = false;
            // 
            // brnRead
            // 
            this.brnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.brnRead.Dock = System.Windows.Forms.DockStyle.Left;
            this.brnRead.FlatAppearance.BorderSize = 0;
            this.brnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnRead.ForeColor = System.Drawing.Color.White;
            this.brnRead.IconChar = FontAwesome.Sharp.IconChar.None;
            this.brnRead.IconColor = System.Drawing.Color.White;
            this.brnRead.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnRead.IconSize = 40;
            this.brnRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnRead.Location = new System.Drawing.Point(0, 0);
            this.brnRead.Name = "brnRead";
            this.brnRead.Size = new System.Drawing.Size(201, 30);
            this.brnRead.TabIndex = 0;
            this.brnRead.Tag = "Считать";
            this.brnRead.Text = "Считать";
            this.brnRead.UseVisualStyleBackColor = false;
            // 
            // plTable
            // 
            this.plTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.plTable.Controls.Add(this.DataGridSetting);
            this.plTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plTable.Location = new System.Drawing.Point(0, 30);
            this.plTable.Name = "plTable";
            this.plTable.Size = new System.Drawing.Size(733, 616);
            this.plTable.TabIndex = 1;
            // 
            // DataGridSetting
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridSetting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridSetting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridSetting.BackgroundColor = System.Drawing.Color.White;
            this.DataGridSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSetting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSetting.ColumnHeadersHeight = 40;
            this.DataGridSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Параметр,
            this.Value});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSetting.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridSetting.EnableHeadersVisualStyles = false;
            this.DataGridSetting.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataGridSetting.Location = new System.Drawing.Point(0, 0);
            this.DataGridSetting.Name = "DataGridSetting";
            this.DataGridSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridSetting.RowHeadersVisible = false;
            this.DataGridSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridSetting.Size = new System.Drawing.Size(531, 616);
            this.DataGridSetting.TabIndex = 0;
            this.DataGridSetting.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.White;
            this.DataGridSetting.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridSetting.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridSetting.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridSetting.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridSetting.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridSetting.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridSetting.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataGridSetting.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridSetting.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridSetting.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridSetting.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridSetting.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridSetting.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridSetting.ThemeStyle.ReadOnly = false;
            this.DataGridSetting.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.DataGridSetting.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridSetting.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridSetting.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridSetting.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridSetting.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridSetting.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridSetting.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridSettings_RowsAdded);
            // 
            // Num
            // 
            this.Num.FillWeight = 50F;
            this.Num.HeaderText = "#";
            this.Num.Name = "Num";
            // 
            // Параметр
            // 
            this.Параметр.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Параметр.HeaderText = "Param";
            this.Параметр.Name = "Параметр";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 646);
            this.Controls.Add(this.plTable);
            this.Controls.Add(this.plbtn);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.plbtn.ResumeLayout(false);
            this.plTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plbtn;
        private FontAwesome.Sharp.IconButton brnRead;
        private System.Windows.Forms.Panel plTable;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnWriteRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Параметр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        public Guna.UI.WinForms.GunaDataGridView DataGridSetting;
    }
}