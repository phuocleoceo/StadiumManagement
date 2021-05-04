using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormQLDichVu : Form
    {
        private readonly ServiceRepository _db;
        public FormQLDichVu()
        {
            _db = new ServiceRepository();
            InitializeComponent();
            dgvDSDichVu.FormatTable();
            LoadData();
        }

        private void LoadData()
        {
            dgvDSDichVu.DataSource = null;
            dgvDSDichVu.Rows.Clear();
            dgvDSDichVu.DataSource = _db.GetList();
            dgvDSDichVu.Columns["Id"].Visible = false;
        }

        private void dgvDSDichVu_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSDichVu.SelectedRows;
            if (r.Count == 1)
            {
                txtTenDichVu.Text = r[0].Cells["Name"].Value.ToString();
                txtDonGia.Text = r[0].Cells["Price"].Value.ToString();
                txtDonViTinh.Text = r[0].Cells["Unit"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _db.AddService(new ServiceVM
            {
                Name = txtTenDichVu.Text,
                Price = double.Parse(txtDonGia.Text),
                Unit = txtDonViTinh.Text
            });
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSDichVu.SelectedRows;
            _db.UpdateService(new ServiceVM
            {
                Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                Name = txtTenDichVu.Text,
                Price = double.Parse(txtDonGia.Text),
                Unit = txtDonViTinh.Text
            });
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSDichVu.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteService(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
            }
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenDichVu.Text = txtDonViTinh.Text = txtDonGia.Text = "";
        }
    }
}
