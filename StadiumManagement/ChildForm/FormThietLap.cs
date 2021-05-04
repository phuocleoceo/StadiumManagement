using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormThietLap : Form
    {
        private readonly AccountRepository _db;
        private AccountVM ac;
        private string imgPath = "";
        public FormThietLap()
        {
            _db = new AccountRepository();
            ac = FormLogin.currentAccount;
            InitializeComponent();
            LoadTaiKhoan();
            LoadThongTinCaNhan();
        }

        public void LoadTaiKhoan()
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

        public void LoadThongTinCaNhan()
        {

        }
    }
}
