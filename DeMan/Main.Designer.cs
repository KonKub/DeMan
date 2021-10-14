
namespace DeMan
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMenu = new System.Windows.Forms.Panel();
            this.btnList = new FontAwesome.Sharp.IconButton();
            this.btnBoot = new FontAwesome.Sharp.IconButton();
            this.btnGraph = new FontAwesome.Sharp.IconButton();
            this.btnParams = new FontAwesome.Sharp.IconButton();
            this.plLogo = new System.Windows.Forms.Panel();
            this.btnMain = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plBtn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFold = new FontAwesome.Sharp.IconButton();
            this.btnSizeMin = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.plForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.plMenu.SuspendLayout();
            this.plLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.plMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plMenu.Controls.Add(this.button1);
            this.plMenu.Controls.Add(this.btnList);
            this.plMenu.Controls.Add(this.btnBoot);
            this.plMenu.Controls.Add(this.btnGraph);
            this.plMenu.Controls.Add(this.btnParams);
            this.plMenu.Controls.Add(this.plLogo);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(214, 679);
            this.plMenu.TabIndex = 2;
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnList.IconColor = System.Drawing.Color.White;
            this.btnList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 353);
            this.btnList.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(214, 85);
            this.btnList.TabIndex = 9;
            this.btnList.Tag = "Список изделий";
            this.btnList.Text = "Список  изделий";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBoot
            // 
            this.btnBoot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBoot.FlatAppearance.BorderSize = 0;
            this.btnBoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoot.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoot.ForeColor = System.Drawing.Color.White;
            this.btnBoot.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnBoot.IconColor = System.Drawing.Color.White;
            this.btnBoot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBoot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoot.Location = new System.Drawing.Point(0, 268);
            this.btnBoot.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(214, 85);
            this.btnBoot.TabIndex = 8;
            this.btnBoot.Tag = "Bootloader";
            this.btnBoot.Text = "Bootloader";
            this.btnBoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraph.ForeColor = System.Drawing.Color.White;
            this.btnGraph.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnGraph.IconColor = System.Drawing.Color.White;
            this.btnGraph.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.Location = new System.Drawing.Point(0, 183);
            this.btnGraph.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(214, 85);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.Tag = "Графики";
            this.btnGraph.Text = "Графики";
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnParams
            // 
            this.btnParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParams.FlatAppearance.BorderSize = 0;
            this.btnParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParams.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParams.ForeColor = System.Drawing.Color.White;
            this.btnParams.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnParams.IconColor = System.Drawing.Color.White;
            this.btnParams.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParams.Location = new System.Drawing.Point(0, 98);
            this.btnParams.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(214, 85);
            this.btnParams.TabIndex = 6;
            this.btnParams.Tag = "Параметры";
            this.btnParams.Text = "Параметры";
            this.btnParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // plLogo
            // 
            this.plLogo.Controls.Add(this.btnMain);
            this.plLogo.Controls.Add(this.pictureBox1);
            this.plLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLogo.Location = new System.Drawing.Point(0, 0);
            this.plLogo.Name = "plLogo";
            this.plLogo.Size = new System.Drawing.Size(214, 98);
            this.plLogo.TabIndex = 5;
            // 
            // btnMain
            // 
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMain.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMain.IconColor = System.Drawing.Color.White;
            this.btnMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMain.Location = new System.Drawing.Point(120, 42);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 50);
            this.btnMain.TabIndex = 1;
            this.btnMain.UseMnemonic = false;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DeMan.Properties.Resources.youtube_profile_image;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 81);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // plBtn
            // 
            this.plBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.plBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plBtn.Controls.Add(this.panel1);
            this.plBtn.Controls.Add(this.labelTitle);
            this.plBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtn.Location = new System.Drawing.Point(214, 0);
            this.plBtn.Name = "plBtn";
            this.plBtn.Size = new System.Drawing.Size(1142, 56);
            this.plBtn.TabIndex = 4;
            this.plBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plBtn_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFold);
            this.panel1.Controls.Add(this.btnSizeMin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1043, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnFold
            // 
            this.btnFold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFold.AutoEllipsis = true;
            this.btnFold.BackColor = System.Drawing.Color.Transparent;
            this.btnFold.FlatAppearance.BorderSize = 0;
            this.btnFold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFold.ForeColor = System.Drawing.Color.White;
            this.btnFold.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnFold.IconColor = System.Drawing.Color.White;
            this.btnFold.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFold.IconSize = 20;
            this.btnFold.Location = new System.Drawing.Point(2, 0);
            this.btnFold.Name = "btnFold";
            this.btnFold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFold.Size = new System.Drawing.Size(32, 19);
            this.btnFold.TabIndex = 2;
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // btnSizeMin
            // 
            this.btnSizeMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSizeMin.AutoEllipsis = true;
            this.btnSizeMin.BackColor = System.Drawing.Color.Transparent;
            this.btnSizeMin.FlatAppearance.BorderSize = 0;
            this.btnSizeMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeMin.ForeColor = System.Drawing.Color.White;
            this.btnSizeMin.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnSizeMin.IconColor = System.Drawing.Color.White;
            this.btnSizeMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSizeMin.IconSize = 20;
            this.btnSizeMin.Location = new System.Drawing.Point(34, 0);
            this.btnSizeMin.Name = "btnSizeMin";
            this.btnSizeMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSizeMin.Size = new System.Drawing.Size(32, 19);
            this.btnSizeMin.TabIndex = 1;
            this.btnSizeMin.UseVisualStyleBackColor = false;
            this.btnSizeMin.Click += new System.EventHandler(this.btnSizeMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoEllipsis = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(67, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(32, 19);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTitle.Location = new System.Drawing.Point(481, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(106, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Главная";
            // 
            // plForm
            // 
            this.plForm.BackColor = System.Drawing.Color.White;
            this.plForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.plForm.Location = new System.Drawing.Point(214, 56);
            this.plForm.Name = "plForm";
            this.plForm.Size = new System.Drawing.Size(1142, 623);
            this.plForm.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Кнопка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1356, 679);
            this.Controls.Add(this.plForm);
            this.Controls.Add(this.plBtn);
            this.Controls.Add(this.plMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "DeMan 1.0.0";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.plMenu.ResumeLayout(false);
            this.plLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plBtn.ResumeLayout(false);
            this.plBtn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Panel plLogo;
        private System.Windows.Forms.Panel plBtn;
        private System.Windows.Forms.Panel plForm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMain;
        private FontAwesome.Sharp.IconButton btnParams;
        private FontAwesome.Sharp.IconButton btnList;
        private FontAwesome.Sharp.IconButton btnBoot;
        private FontAwesome.Sharp.IconButton btnGraph;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSizeMin;
        private FontAwesome.Sharp.IconButton btnFold;
        private System.Windows.Forms.Button button1;
    }
}

