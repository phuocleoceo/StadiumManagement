using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using FontAwesome.Sharp;
using GUILayer.ChildForm;
using MaterialSkin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormControl : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormControl()
        {
            InitializeComponent();
            InitializeUI();
            Authorization();
            SetupMaterialSkin();
        }

        #region Authorization
        public void Authorization()
        {
            AccountVM currentAcc = (new AccountRepository()).GetAccountById(FormLogin.currentAccount_Id);
            AccountInformationVM currentAccIfo = (new AccountInformationRepository()).GetAIByAccountId(FormLogin.currentAccount_Id);
            string Name = currentAccIfo != null ? currentAccIfo.Name : "";
            if (currentAcc.Role != "Admin")
            {
                lblRole.Text = $"Thu Ngân {Name}";
                btnStadium.Visible = false;
                btnService.Visible = false;
                btnCashier.Visible = false;
            }
            else lblRole.Text = $"Quản lý {Name}";
            picLogo.Image = currentAcc.Image.ByteArrayToImage();
        }
        #endregion

        #region InitializeUI
        private void InitializeUI()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(leftBorderBtn);
            timer.Start();//dong ho
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //RoundCorner
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        #endregion

        #region MaterialSkin
        private void SetupMaterialSkin()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_12 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            materialSkinManager.ROBOTO_MEDIUM_11 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
            //materialSkinManager.ROBOTO_MEDIUM_10 = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
        }
        #endregion

        #region SubPanel Design  

        private void HideSubMenu()
        {
            if (pnlCashier.Visible == true)
                pnlCashier.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region ChildForm Design 
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

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon small
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;

            }
        }

        private void DisableButton()
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

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentForm.Text = childForm.Text;
            childForm.BackColor = Color.WhiteSmoke;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Home;
            iconCurrentForm.IconColor = Color.Gainsboro;
            lblCurrentForm.Text = "Home";
        }
        #endregion

        #region Logo, Timer, Exit , Minimize , Zoom
        private void picLogo_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.lblTime.Text = datetime.ToString("HH:mm:ss");
            this.lblDMY.Text = datetime.ToString("dd/MM/yyyy");
            this.lblDate.Text = datetime.ToString("dddd");
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

        #region PanelTitleBar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region RoundCorner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private extern static IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #endregion

        #region ButtonClick
        private void btnStadium_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FormQLSan());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FormQLDichVu());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FormDSKH());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FormThongKe());
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlCashier);
            ActiveButton(sender, RGBColors.color3);
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSNV());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FormHoaDon());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FormThietLap());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActiveButton(sender, RGBColors.color7);
            this.Close();
        }
        #endregion
    }
}
