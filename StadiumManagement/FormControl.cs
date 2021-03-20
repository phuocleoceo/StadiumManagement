using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormControl : Form
    {
        private IconButton currentBtn;
        private Panel lefBorderBtn;
        private Form currentChildForm;

        public static string UserName = "";

        public FormControl()
        {
            InitializeComponent();
            lefBorderBtn = new Panel();
            lefBorderBtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(lefBorderBtn);
            timer.Start();//dong ho
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(145, 151, 154);
        }

        private void activeBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableBtn();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border btn
                lefBorderBtn.BackColor = color;
                lefBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                lefBorderBtn.Visible = true;
                lefBorderBtn.BringToFront();

                //icon small
                iconmenusmall.IconChar = currentBtn.IconChar;
                iconmenusmall.IconColor = color;

            }
        }

        private void disableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(34, 36, 49);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();

            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneltrangcon.Controls.Add(childForm);
            paneltrangcon.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelcon.Text = childForm.Text;
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color1);
            //motrangcon(new BanHang());
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color2);
            //motrangcon(new donhang());
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color3);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color4);
            //motrangcon(new Dashboard());
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color6);
            //motrangcon(new sanpham());
        }

        private void btnluong_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color3);
            //motrangcon(new tonkho());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            activeBtn(sender, RGBColors.color7);
            Application.Restart();
        }

        private void Reset()
        {
            disableBtn();
            lefBorderBtn.Visible = false;
            iconmenusmall.IconChar = IconChar.Home;
            iconmenusmall.IconColor = Color.Gainsboro;
            labelcon.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void MainControl_Load(object sender, EventArgs e)
        {

        }

        private void paneltrangcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonSP_Click(object sender, EventArgs e)
        {
            //activebtn(sender, RGBColors.color3);
            if (PanelDropDownSP.Height == 200)
            {
                PanelDropDownSP.Height = 50;
            }
            else
            {
                PanelDropDownSP.Height = 200;
            }
        }

        private void iconButtonSPLoai_Click(object sender, EventArgs e)
        {
            //motrangcon(new LoaiSP());
        }

        private void iconButtonSPDonvi_Click(object sender, EventArgs e)
        {
            //motrangcon(new DonViSP());
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            //motrangcon(new Setting());
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.labelGioBig.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThangBig.Text = datetime.ToString("dd/MM/yyyy");
            this.lbDateBig.Text = datetime.ToString("dddd");
        }
    }
}
