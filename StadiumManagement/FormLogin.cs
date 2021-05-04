using BusinessLayer.Repository;
using System;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormLogin : Form
    {
        private readonly AccountRepository _db;
        public static bool isAdmin;
        public FormLogin()
        {
            _db = new AccountRepository();
            InitializeComponent();
            btnHidePass.Hide();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string un = txtuser.Text;
            string pw = txtpass.Text;
            bool check = _db.Authentication(un, pw);
            if (check)
            {
                isAdmin = _db.Authorization(un, pw);
                FormControl fc = new FormControl();
                this.Hide();
                fc.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect !");
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            btnHidePass.Hide();
            btnShowPass.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            btnShowPass.Hide();
            btnHidePass.Show();
        }
    }
}
