
namespace DeMan
{
    partial class Bootloader
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
            this.plBtn = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnWrite = new FontAwesome.Sharp.IconButton();
            this.btnEntry = new FontAwesome.Sharp.IconButton();
            this.btnOpen = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbProcess = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI.WinForms.GunaProgressBar();
            this.plBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBtn
            // 
            this.plBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.plBtn.Controls.Add(this.btnSave);
            this.plBtn.Controls.Add(this.btnWrite);
            this.plBtn.Controls.Add(this.btnEntry);
            this.plBtn.Controls.Add(this.btnOpen);
            this.plBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtn.Location = new System.Drawing.Point(0, 0);
            this.plBtn.Name = "plBtn";
            this.plBtn.Size = new System.Drawing.Size(653, 52);
            this.plBtn.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(441, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "    Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnWrite.IconColor = System.Drawing.Color.White;
            this.btnWrite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWrite.IconSize = 40;
            this.btnWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWrite.Location = new System.Drawing.Point(294, 0);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 52);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Запись";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnEntry.IconColor = System.Drawing.Color.White;
            this.btnEntry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEntry.IconSize = 40;
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.Location = new System.Drawing.Point(147, 0);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(147, 52);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "        Вход в        загрузчик";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnOpen.IconColor = System.Drawing.Color.White;
            this.btnOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpen.IconSize = 40;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(147, 52);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "           Открыть        hex -  файл";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lbProcess);
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 557);
            this.panel1.TabIndex = 1;
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.BackColor = System.Drawing.Color.Gainsboro;
            this.lbProcess.Location = new System.Drawing.Point(314, 483);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(21, 13);
            this.lbProcess.TabIndex = 1;
            this.lbProcess.Text = "0%";
            // 
            // ProgressBar
            // 
            this.ProgressBar.BorderColor = System.Drawing.Color.Black;
            this.ProgressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DeMan.Properties.Settings.Default, "ProcessText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.ProgressBar.Location = new System.Drawing.Point(44, 476);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProgressBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProgressBar.Size = new System.Drawing.Size(544, 27);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = global::DeMan.Properties.Settings.Default.ProcessText;
            // 
            // Bootloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plBtn);
            this.Name = "Bootloader";
            this.Text = "Bootloader";
            this.Shown += new System.EventHandler(this.Bootloader_Shown);
            this.plBtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plBtn;
        private FontAwesome.Sharp.IconButton btnOpen;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnWrite;
        private FontAwesome.Sharp.IconButton btnEntry;
        private FontAwesome.Sharp.IconButton btnSave;
        private Guna.UI.WinForms.GunaProgressBar ProgressBar;
        private System.Windows.Forms.Label lbProcess;
    }
}