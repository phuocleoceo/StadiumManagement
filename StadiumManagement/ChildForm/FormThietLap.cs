using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Windows.Forms;
using static GUILayer.AlertType;

namespace GUILayer.ChildForm
{
    public partial class FormThietLap : Form
    {
        private readonly AccountRepository _db;
        private readonly AccountInformationRepository _dbAI;
        private readonly AccountVM ac;
        private readonly AccountInformationVM ai;
        public FormThietLap()
        {
            InitializeComponent();
            _db = new AccountRepository();
            _dbAI = new AccountInformationRepository();
            ac = _db.GetAccountById(FormLogin.currentAccount_Id);
            ai = _dbAI.GetAIByAccountId(ac.Id);
            LoadAccount();
            LoadAccountInformation();
            HidePassword();
        }

        public void LoadAccount()
        {
            txtTenTaiKhoan.Text = ac.UserName;
            picTaiKhoan.Image = ac.Image.ByteArrayToImage();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picTaiKhoan.ImageLocation = dlg.FileName;
            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            int id = ac.Id;
            byte[] img = picTaiKhoan.Image.ImageToByteArray();
            _db.SaveImage(id, img);
            new FormAlert("Lưu ảnh thành công", Success);
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
                    new FormAlert("Đổi mật khẩu thành công", Success);
                    txtMKCu.Text = txtMKMoi.Text = txtXacNhanMK.Text = "";
                }
                else
                {
                    new FormAlert("Mật khẩu cũ không đúng !", Error);
                }
            }
            else
            {
                new FormAlert("Xác nhận mật khẩu sai !", Infor);
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
            try
            {
                _dbAI.UpdateAccountInformation(new AccountInformationVM
                {
                    Id = ai.Id,
                    Name = txtTen.Text,
                    Gender = (rdbNam.Checked) ? true : false,
                    DateOfBirth = dtpNgaySinh.Value,
                    PhoneNumber = txtSoDienThoai.Text,
                    IdentityCard = txtCMND.Text,
                    Salary = ai.Salary,
                    Address = txtDiaChi.Text,
                    Account_Id = ai.Account_Id
                });
                new FormAlert("Lưu thông tin thành công", Success);
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Infor);
            }
        }

        private void HidePassword()
        {
            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
        }
        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = !ckbShowPass.Checked;
            txtMKMoi.UseSystemPasswordChar = !ckbShowPass.Checked;
            txtXacNhanMK.UseSystemPasswordChar = !ckbShowPass.Checked;
        }
    }
}
