using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;
using System.IO;
using System.Drawing;
using System.Text;

namespace GUILayer.ChildForm
{
    public partial class FormQLDichVu : Form
    {
        private readonly ServiceRepository _db;
        public FormQLDichVu()
        {
            InitializeComponent();
            dgvDSDichVu.FormatTable();
            _db = new ServiceRepository();
            LoadData();
        }

        private void LoadData(string ServiceName = "")
        {
            dgvDSDichVu.DataSource = null;
            dgvDSDichVu.Rows.Clear();
            dgvDSDichVu.DataSource = _db.GetList(ServiceName);
            dgvDSDichVu.Columns["Id"].Visible = false;
            dgvDSDichVu.Columns["Image"].Visible = false;
        }

        private void dgvDSDichVu_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSDichVu.SelectedRows;
            if (r.Count == 1)
            {
                txtTenDichVu.Text = r[0].Cells["Name"].Value.ToString();
                txtDonGia.Text = r[0].Cells["Price"].Value.ToString();
                txtDonViTinh.Text = r[0].Cells["Unit"].Value.ToString();
                picDV.Image = ((byte[])(r[0].Cells["Image"].Value)).ByteArrayToImage();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _db.AddService(new ServiceVM
                {
                    Name = txtTenDichVu.Text,
                    Price = double.Parse(txtDonGia.Text),
                    Unit = txtDonViTinh.Text,
                    Image = picDV.Image.ImageToByteArray()
                });
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection r = dgvDSDichVu.SelectedRows;
                _db.UpdateService(new ServiceVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Name = txtTenDichVu.Text,
                    Price = double.Parse(txtDonGia.Text),
                    Unit = txtDonViTinh.Text,
                    Image = picDV.Image.ImageToByteArray()
                });
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            picDV.Image = null;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picDV.ImageLocation = dlg.FileName;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
