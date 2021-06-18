using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUILayer.AlertType;

namespace GUILayer
{
    public partial class FormLogin : Form
    {
        private AccountRepository _db;
        private AccountInformationRepository _dbAI;
        public static int currentAccount_Id;
        public FormLogin()
        {
            InitEF();
            InitializeComponent();
            if (txtPass.Text == "Mật khẩu") txtPass.UseSystemPasswordChar = false;
            btnHidePass.Hide();
        }

        private Task InitEF()
        {
            var task = new Task(() =>
            {
                _db = new AccountRepository();
                _dbAI = new AccountInformationRepository();
                _db.InitEF();
            });
            task.Start();
            return task;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string un = txtUser.Text;
                string pw = txtPass.Text;
                currentAccount_Id = _db.Authentication(un, pw);
                if (currentAccount_Id > 0)
                {
                    AccountVM currentAcc = _db.GetAccountById(currentAccount_Id);
                    AccountInformationVM currentAccIfo = _dbAI.GetAIByAccountId(currentAccount_Id);
                    string Name = currentAccIfo != null ? currentAccIfo.Name : "";
                    if (currentAcc.Role == "Admin")
                    {
                        MessageBox.Show($"Chào mừng Quản lý {Name}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Chào mừng Thu Ngân {Name}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormControl fc = new FormControl();
                    this.Hide();
                    fc.ShowDialog();
                    this.Show();
                    txtUser.Text = "Tài khoản";
                    txtPass.Text = "Mật khẩu";
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                new FormAlert("Chưa tải xong Database !", Error);
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnHidePass.Hide();
            btnShowPass.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnShowPass.Hide();
            btnHidePass.Show();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
