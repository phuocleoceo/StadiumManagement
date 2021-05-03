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
            _db = new AccountInformationRepository();
            InitializeComponent();
            dgvDSNV.FormatTable();
            LoadData();
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
                txtTaiKhoan.Text = r[0].Cells["UserName"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = txtTaiKhoan.Text =
                txtSoDienThoai.Text = txtLuong.Text = txtDiaChi.Text = txtCMND.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }
    }
}
