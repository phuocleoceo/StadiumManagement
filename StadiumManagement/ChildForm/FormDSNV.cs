using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormDSNV : Form
    {
        private readonly AccountInformationRepository _db;
        public FormDSNV()
        {
            InitializeComponent();
            dgvDSNV.FormatTable();
            _db = new AccountInformationRepository();            
            LoadData();
            cbbTaiKhoan.DataSource = _db.LoadComboBox();
        }

        private void LoadData()
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.Rows.Clear();
            dgvDSNV.DataSource = _db.GetList();
            dgvDSNV.Columns["Id"].Visible = false;
        }

        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
            if (r.Count == 1)
            {
                txtTenNhanVien.Text = r[0].Cells["Name"].Value.ToString();
                txtDiaChi.Text = r[0].Cells["Address"].Value.ToString();
                txtSoDienThoai.Text = r[0].Cells["PhoneNumber"].Value.ToString();
                bool gender = Convert.ToBoolean(r[0].Cells["Gender"].Value);
                if (gender)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                dtpNgaySinh.Value = Convert.ToDateTime(r[0].Cells["DateOfBirth"].Value);
                txtCMND.Text = r[0].Cells["IdentityCard"].Value.ToString();
                txtLuong.Text = r[0].Cells["Salary"].Value.ToString();
                cbbTaiKhoan.Text = r[0].Cells["AccountName"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = cbbTaiKhoan.Text =
                txtSoDienThoai.Text = txtLuong.Text = txtDiaChi.Text = txtCMND.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteAccountInformation(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
            }
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _db.AddAccountInformation(new AccountInformationVM
            {
                Name = txtTenNhanVien.Text,
                Gender = rdbNam.Checked ? true : false,
                DateOfBirth = dtpNgaySinh.Value,
                PhoneNumber = txtSoDienThoai.Text,
                IdentityCard = txtCMND.Text,
                Salary = float.Parse(txtLuong.Text),
                Address = txtDiaChi.Text,
                Account_Name = cbbTaiKhoan.Text,
                Account_Id = ((CBBItem)cbbTaiKhoan.SelectedItem).Value
            });
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
            _db.UpdateAccountInformation(new AccountInformationVM
            {
                Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                Name = txtTenNhanVien.Text,
                Gender = rdbNam.Checked ? true : false,
                DateOfBirth = dtpNgaySinh.Value,
                PhoneNumber = txtSoDienThoai.Text,
                IdentityCard = txtCMND.Text,
                Salary = float.Parse(txtLuong.Text),
                Address = txtDiaChi.Text,
                Account_Name = cbbTaiKhoan.Text,
                Account_Id = ((CBBItem)cbbTaiKhoan.SelectedItem).Value
            });
            LoadData();
        }
    }
}
