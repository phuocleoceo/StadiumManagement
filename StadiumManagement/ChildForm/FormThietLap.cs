using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormThietLap : Form
    {
        private readonly AccountRepository _db;
        private readonly AccountInformationRepository _dbAI;
        private readonly AccountVM ac;
        private readonly AccountInformationVM ai;
        private string imgPath = "";
        public FormThietLap()
        {
            InitializeComponent();
            _db = new AccountRepository();
            _dbAI = new AccountInformationRepository();
            ac = _db.GetAccountById(FormLogin.currentAccount_Id);
            ai = _dbAI.GetAIByAccountId(ac.Id);
            LoadAccount();
            LoadAccountInformation();
        }

        public void LoadAccount()
        {
            txtTenTaiKhoan.Text = ac.UserName;
            picTaiKhoan.LoadImage(ac.Image);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgPath = dlg.FileName.ToString();
                picTaiKhoan.ImageLocation = imgPath;
            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            int id = ac.Id;
            byte[] img = imgPath.ImageToByte();
            _db.SaveImage(id, img);
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMKMoi.Text == txtXacNhanMK.Text)
            {
                int id = ac.Id;
                string oldPW = txtMKCu.Text;
                string newPW = txtMKMoi.Text;
                if (_db.CheckPassword(id, oldPW))
                {
                    _db.ChangePassword(id, newPW);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtMKCu.Text = txtMKMoi.Text = txtXacNhanMK.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng !");
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu sai !");
            }
        }

        public void LoadAccountInformation()
        {
            if (ai != null)
            {
                txtTen.Text = ai.Name;
                txtSoDienThoai.Text = ai.PhoneNumber;
                txtCMND.Text = ai.IdentityCard;
                txtDiaChi.Text = ai.Address;
                dtpNgaySinh.Value = ai.DateOfBirth;
                if (ai.Gender == true)
                {
                    rdbNam.Checked = true;
                }
                else rdbNu.Checked = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _dbAI.UpdateAccountInformationFromSetting(new AccountInformationVM
            {
                Id = ai.Id,
                Name = txtTen.Text,
                Gender = (rdbNam.Checked) ? true : false,
                DateOfBirth = dtpNgaySinh.Value,
                PhoneNumber = txtSoDienThoai.Text,
                IdentityCard = txtCMND.Text,
                Address = txtDiaChi.Text
            });
        }
    }
}
