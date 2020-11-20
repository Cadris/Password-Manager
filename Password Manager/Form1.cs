using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Password_Manager.Forms;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            timer1.Start();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            btnHome.Image = Properties.Resources.Logo1;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        /*protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }*/

        //Move Window 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }//move window

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Methods to form Active Button
        
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);            
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new genPasswordForm());
        }

        private void btnPassVlt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                //open only one child form at once
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnCross_MouseHover(object sender, EventArgs e)
        {
            btnCross.BackColor = Color.FromArgb(1, 233, 32, 22);
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.FromArgb(1, 84, 125, 90);
        }

        private void iconButton2_MouseHover(object sender, EventArgs e)
        {
            iconButton2.BackColor = Color.FromArgb(1, 199, 194, 42);
        }

        //child Form Operation

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!=null)
            {
                //open only one child form at once
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //Set 1 End

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Clock Functions
        private void innClock()
        {
            DateTime dt = new DateTime();
            try
            {
                secLabel.Text = DateTime.Now.ToString("ss");
                hrminLabel.Text = DateTime.Now.ToString("hh:mm");
                dayLabel.Text = DateTime.Now.ToString("dddd");
                dateLabel.Text = DateTime.Now.ToString("dd/M/yyyy");
                circularProgressBar1.Value = Convert.ToInt32(secLabel.Text);

            }
            catch (Exception)
            {
                return;
            }


            String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   year
            String.Format("{0:M MM MMM MMMM}", dt);  // "3 03 Mar March"  month
            String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" day
            String.Format("{0:h hh H HH}", dt);  // "4 04 16 16"      hour 12/24
            String.Format("{0:m mm}", dt);  // "5 05"            minute
            String.Format("{0:s ss}", dt);  // "7 07"            second
            String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230"   sec.fraction
            String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123"    without zeroes
            String.Format("{0:t tt}", dt);  // "P PM"            A.M. or P.M.
            String.Format("{0:z zz zzz}", dt);  // "-6 -06 -06:00"   time zone
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            innClock();
        }
        //clock functions (End)
    }

}
