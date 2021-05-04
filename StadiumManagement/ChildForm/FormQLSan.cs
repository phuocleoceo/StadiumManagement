using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormQLSan : Form
    {
        private readonly StadiumRepository _db;
        string imgPath = "";
        public FormQLSan()
        {
            _db = new StadiumRepository();
            InitializeComponent();
            dgvDSSan.FormatTable();
            LoadData();
        }

        private void LoadData()
        {
            dgvDSSan.DataSource = null;
            dgvDSSan.Rows.Clear();
            dgvDSSan.DataSource = _db.GetList();
            dgvDSSan.Columns["Id"].Visible = false;
            dgvDSSan.Columns["Image"].Visible = false;
        }

        private void dgvDSSan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSSan.SelectedRows;
            if (r.Count == 1)
            {
                txtTenSan.Text = r[0].Cells["Name"].Value.ToString();
                txtDonGia.Text = r[0].Cells["Price"].Value.ToString();
                txtDienTich.Text = r[0].Cells["Area"].Value.ToString();
                txtGhiChu.Text = r[0].Cells["Note"].Value.ToString();
                picSB.LoadImage((byte[])(r[0].Cells["Image"].Value));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _db.AddStadium(new StadiumVM
            {
                Name = txtTenSan.Text,
                Price = double.Parse(txtDonGia.Text),
                Area = txtDienTich.Text,
                Note = txtGhiChu.Text,
                Image = imgPath.ImageToByte()
            });
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSSan.SelectedRows;
            _db.UpdateStadium(new StadiumVM
            {
                Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                Name = txtTenSan.Text,
                Price = double.Parse(txtDonGia.Text),
                Area = txtDienTich.Text,
                Note = txtGhiChu.Text,
                Image = imgPath.ImageToByte()
            });
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSSan.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteStadium(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
            }
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenSan.Text = txtGhiChu.Text = txtDonGia.Text = txtDienTich.Text = "";
            picSB.Image = null;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgPath = dlg.FileName.ToString();
                picSB.ImageLocation = imgPath;
            }
        }
    }
}
