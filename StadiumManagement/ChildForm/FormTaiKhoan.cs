using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormTaiKhoan : Form
    {
        private readonly AccountRepository _db;
        public FormTaiKhoan()
        {
            InitializeComponent();
            dgvDSTK.FormatTable();
            _db = new AccountRepository();
            LoadData();
        }

        private void LoadData()
        {
            dgvDSTK.DataSource = null;
            dgvDSTK.Rows.Clear();
            dgvDSTK.DataSource = _db.GetList();
            dgvDSTK.Columns["Id"].Visible = false;
            dgvDSTK.Columns["Image"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = cbbVaiTro.Text = "";
        }

        private void dgvDSTK_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSTK.SelectedRows;
            if (r.Count == 1)
            {
                txtTenTaiKhoan.Text = r[0].Cells["UserName"].Value.ToString();
                cbbVaiTro.Text = r[0].Cells["Role"].Value.ToString();
                picTK.Image = ((byte[])(r[0].Cells["Image"].Value)).ByteArrayToImage();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSTK.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteAccount(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
            }
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            try
            {
                DataGridViewSelectedRowCollection r = dgvDSTK.SelectedRows;
                _db.UpdateAccount(new AccountVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    UserName = txtTenTaiKhoan.Text,
                    Role = cbbVaiTro.Text
                });
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            picTK.Image = null;
            grbThem.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _db.AddAccount(new AccountVM
                {
                    UserName = txtTenTaiKhoan.Text,
                    PassWord = txtMatKhau.Text,
                    Role = cbbVaiTro.Text
                });
                LoadData();
                grbThem.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbThem.Visible = false;
        }
    }
}
