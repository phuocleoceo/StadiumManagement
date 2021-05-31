using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormQLSan : Form
    {
        private readonly StadiumRepository _db;
        public FormQLSan()
        {
            InitializeComponent();
            dgvDSSan.FormatTable();
            _db = new StadiumRepository();
            LoadData();
        }

        private void LoadData(string StadiumName = "")
        {
            dgvDSSan.DataSource = null;
            dgvDSSan.Rows.Clear();
            dgvDSSan.DataSource = _db.GetList(StadiumName).ToList();
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
                picSB.Image = ((byte[])(r[0].Cells["Image"].Value)).ByteArrayToImage();
                if (Convert.ToBoolean(r[0].Cells["Rentable"].Value)) rdbCo.Checked = true;
                else rdbKhong.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _db.AddStadium(new StadiumVM
                {
                    Name = txtTenSan.Text,
                    Price = double.Parse(txtDonGia.Text),
                    Rentable = rdbCo.Checked ? true : false,
                    Area = txtDienTich.Text,
                    Note = txtGhiChu.Text,
                    Image = picSB.Image.ImageToByteArray()
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
                DataGridViewSelectedRowCollection r = dgvDSSan.SelectedRows;
                _db.UpdateStadium(new StadiumVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Name = txtTenSan.Text,
                    Price = double.Parse(txtDonGia.Text),
                    Rentable = rdbCo.Checked ? true : false,
                    Area = txtDienTich.Text,
                    Note = txtGhiChu.Text,
                    Image = picSB.Image.ImageToByteArray()
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
                picSB.ImageLocation = dlg.FileName;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
