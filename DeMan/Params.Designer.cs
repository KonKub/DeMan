
namespace DeMan
{
    partial class Params
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
            this.brnRead = new FontAwesome.Sharp.IconButton();
            this.plTable = new System.Windows.Forms.Panel();
            this.DataGridParams = new Guna.UI.WinForms.GunaDataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Параметр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plbtn.SuspendLayout();
            this.plTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParams)).BeginInit();
            this.SuspendLayout();
            // 
            // plbtn
            // 
            this.plbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.plbtn.Controls.Add(this.brnRead);
            this.plbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plbtn.Location = new System.Drawing.Point(0, 0);
            this.plbtn.Name = "plbtn";
            this.plbtn.Size = new System.Drawing.Size(800, 30);
            this.plbtn.TabIndex = 0;
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
            this.plTable.Controls.Add(this.DataGridParams);
            this.plTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTable.Location = new System.Drawing.Point(0, 30);
            this.plTable.Name = "plTable";
            this.plTable.Size = new System.Drawing.Size(800, 398);
            this.plTable.TabIndex = 1;
            // 
            // DataGridParams
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridParams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridParams.BackgroundColor = System.Drawing.Color.White;
            this.DataGridParams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridParams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridParams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridParams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridParams.ColumnHeadersHeight = 21;
            this.DataGridParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Параметр,
            this.Value});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridParams.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridParams.EnableHeadersVisualStyles = false;
            this.DataGridParams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridParams.Location = new System.Drawing.Point(0, 0);
            this.DataGridParams.Name = "DataGridParams";
            this.DataGridParams.RowHeadersVisible = false;
            this.DataGridParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridParams.Size = new System.Drawing.Size(800, 398);
            this.DataGridParams.TabIndex = 0;
            this.DataGridParams.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridParams.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridParams.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridParams.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridParams.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridParams.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridParams.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridParams.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridParams.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridParams.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridParams.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridParams.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridParams.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridParams.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridParams.ThemeStyle.ReadOnly = false;
            this.DataGridParams.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridParams.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridParams.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridParams.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridParams.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridParams.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridParams.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Num
            // 
            this.Num.HeaderText = "#";
            this.Num.Name = "Num";
            // 
            // Параметр
            // 
            this.Параметр.HeaderText = "Param";
            this.Параметр.Name = "Параметр";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plTable);
            this.Controls.Add(this.plbtn);
            this.Name = "Params";
            this.Text = "Params";
            this.plbtn.ResumeLayout(false);
            this.plTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridParams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plbtn;
        private FontAwesome.Sharp.IconButton brnRead;
        private System.Windows.Forms.Panel plTable;
        private Guna.UI.WinForms.GunaDataGridView DataGridParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Параметр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}