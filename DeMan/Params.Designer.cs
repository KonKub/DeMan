
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
            this.plbtn = new System.Windows.Forms.Panel();
            this.brnRead = new FontAwesome.Sharp.IconButton();
            this.plTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vallue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.plbtn.SuspendLayout();
            this.plTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plbtn
            // 
            this.plbtn.BackColor = System.Drawing.Color.White;
            this.plbtn.Controls.Add(this.iconButton1);
            this.plbtn.Controls.Add(this.brnRead);
            this.plbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plbtn.Location = new System.Drawing.Point(0, 0);
            this.plbtn.Name = "plbtn";
            this.plbtn.Size = new System.Drawing.Size(800, 53);
            this.plbtn.TabIndex = 0;
            // 
            // brnRead
            // 
            this.brnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.brnRead.FlatAppearance.BorderSize = 0;
            this.brnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brnRead.ForeColor = System.Drawing.Color.White;
            this.brnRead.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.brnRead.IconColor = System.Drawing.Color.White;
            this.brnRead.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brnRead.IconSize = 40;
            this.brnRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnRead.Location = new System.Drawing.Point(0, 0);
            this.brnRead.Name = "brnRead";
            this.brnRead.Size = new System.Drawing.Size(201, 53);
            this.brnRead.TabIndex = 0;
            this.brnRead.Text = "Считать";
            this.brnRead.UseVisualStyleBackColor = false;
            // 
            // plTable
            // 
            this.plTable.Controls.Add(this.dataGridView1);
            this.plTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTable.Location = new System.Drawing.Point(0, 53);
            this.plTable.Name = "plTable";
            this.plTable.Size = new System.Drawing.Size(800, 398);
            this.plTable.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Param,
            this.Vallue});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // Num
            // 
            this.Num.HeaderText = "№";
            this.Num.Name = "Num";
            // 
            // Param
            // 
            this.Param.HeaderText = "Параметр";
            this.Param.Name = "Param";
            // 
            // Vallue
            // 
            this.Vallue.HeaderText = "Значение";
            this.Vallue.Name = "Vallue";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Walking;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(198, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(201, 53);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Считать";
            this.iconButton1.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plbtn;
        private FontAwesome.Sharp.IconButton brnRead;
        private System.Windows.Forms.Panel plTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vallue;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}