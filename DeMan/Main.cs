using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DeMan
{
    public partial class Main : Form
    {
        //Координаты мышки
        private int borderSize = 2;
        private Size formSize;

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Main()
        {
            InitializeComponent();
            CollapsMenu();
            random = new Random();
            this.Padding = new Padding(borderSize);

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Method
        private Color SelectThemeColor()
        {
            int index = random.Next(ColorChoice.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorChoice.ColorList.Count);
            }
            tempIndex = index;
            return ColorTranslator.FromHtml(ColorChoice.ColorList[index]);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    plBtn.BackColor = color;
                    plLogo.BackColor = ColorChoice.ChangeColorBrightness(color, -0.3);
                   //Uncomment labelTitle.Text = (btnSender as Button).Tag.ToString();
                    btnMain.ForeColor = color;
                }

            }

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.plForm.Controls.Add(childForm);
            this.plForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //label1.Text = childForm.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in plMenu.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                previousBtn.ForeColor = Color.Gainsboro;
            }
        }

        private void plBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0,8,8,0); 
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void btnFold_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSizeMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnParams_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Params(), sender);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
           //OpenChildForm(new Graph(), sender);
        }

        private void btnBoot_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            CollapsMenu();
        }

        private void CollapsMenu()
        {
            if (this.plMenu.Width > 200)
            {
                this.plMenu.Width = 100;
                this.pictureBox1.Visible = false;
                btnMain.Dock = DockStyle.Top;
                foreach (Button menuButton in this.plMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                this.plMenu.Width = 230;
                this.pictureBox1.Visible = true;
                btnMain.Dock = DockStyle.None;
                foreach (Button menuButton in this.plMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,8,8,8);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new USB(), sender);
        }
    }
}
