using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
using static GUILayer.AlertType;

namespace GUILayer.ChildForm
{
    public partial class FormDSKH : Form
    {
        private readonly CustomerRepository _db;
        public FormDSKH()
        {
            InitializeComponent();
            dgvDSKH.FormatTable();
            _db = new CustomerRepository();
            LoadData();
        }

        private void LoadData(string Name = "")
        {
            dgvDSKH.DataSource = null;
            dgvDSKH.Rows.Clear();
            dgvDSKH.DataSource = _db.GetList(Name).ToList();
            dgvDSKH.Columns["Id"].Visible = false;
        }

        private void dgvDSKH_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
            if (r.Count == 1)
            {
                txtTenKhachHang.Text = r[0].Cells["Name"].Value.ToString();
                txtDiaChi.Text = r[0].Cells["Address"].Value.ToString();
                txtSoDienThoai.Text = r[0].Cells["PhoneNumber"].Value.ToString();
                bool gender = Convert.ToBoolean(r[0].Cells["Gender"].Value);
                if (gender)
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _db.AddCustomer(new CustomerVM
                {
                    Name = txtTenKhachHang.Text,
                    Gender = rdbNam.Checked ? true : false,
                    Address = txtDiaChi.Text,
                    PhoneNumber = txtSoDienThoai.Text
                });
                new FormAlert("Thêm khách hàng thành công", Success);
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
                DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
                _db.UpdateCustomer(new CustomerVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Name = txtTenKhachHang.Text,
                    Gender = rdbNam.Checked ? true : false,
                    Address = txtDiaChi.Text,
                    PhoneNumber = txtSoDienThoai.Text
                });
                new FormAlert("Sửa khách hàng thành công", Success);
                LoadData();
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSKH.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteCustomer(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    new FormAlert("Xoá khách hàng thành công", Success);
                }
            }
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = txtSoDienThoai.Text = txtDiaChi.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
