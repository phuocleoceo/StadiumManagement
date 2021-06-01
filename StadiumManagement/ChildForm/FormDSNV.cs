using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
using static GUILayer.AlertType;

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
            _db.LoadComboBoxAccount(cbbTaiKhoan);
        }

        private void LoadData(string Name = "")
        {
            dgvDSNV.DataSource = null;
            dgvDSNV.Rows.Clear();
            dgvDSNV.DataSource = _db.GetList(Name).ToList();
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
                if (Convert.ToBoolean(r[0].Cells["Gender"].Value))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                dtpNgaySinh.Value = Convert.ToDateTime(r[0].Cells["DateOfBirth"].Value);
                txtCMND.Text = r[0].Cells["IdentityCard"].Value.ToString();
                txtLuong.Text = r[0].Cells["Salary"].Value.ToString();
                cbbTaiKhoan.Text = r[0].Cells["Account_Name"].Value.ToString();
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
                    new FormAlert("Xoá nhân viên thành công", Success);
                }
            }
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
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
                new FormAlert("Thêm nhân viên thành công", Success);
                LoadData();
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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
                new FormAlert("Sửa nhân viên thành công", Success);
                LoadData();
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
