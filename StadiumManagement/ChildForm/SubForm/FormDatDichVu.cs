using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static GUILayer.AlertType;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormDatDichVu : Form
    {
        private ServiceOrderRepository _db;
        private readonly int _currentBillId;
        public FormDatDichVu(int Bill_Id, string Bill_Code)
        {
            InitializeComponent();
            this.ControlBox = false;
            txtHoaDon.Text = Bill_Code;
            _currentBillId = Bill_Id;
            dgvDV.FormatTable();
            LoadData();
        }

        private void LoadData(string ServiceName = "")
        {
            _db = new ServiceOrderRepository();
            dgvDV.DataSource = null;
            dgvDV.Rows.Clear();
            dgvDV.DataSource = _db.GetList(_currentBillId, ServiceName).ToSortableBindingList();
            dgvDV.Columns["Id"].Visible = false;
            dgvDV.Columns["Service_Image"].Visible = false;
            dgvDV.Columns["Service_Price"].Visible = false;
            dgvDV.Columns["Service_Id"].Visible = false;
            dgvDV.Columns["Bill_Code"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTongTien.Text = "";
            NUDSoLuong.Value = 0;
            lblDichVu.Text = "Click to choose ...";
            lblGia.Text = "";
            picDV.Image = null;
            picDV.Tag = "";
        }

        private void dgvDV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDV.SelectedRows;
            if (r.Count == 1)
            {
                NUDSoLuong.Value = Convert.ToDecimal(r[0].Cells["Count"].Value);
                txtTongTien.Text = r[0].Cells["Total"].Value.ToString();
                picDV.Tag = r[0].Cells["Service_Id"].Value;
                picDV.Image = ((byte[])(r[0].Cells["Service_Image"].Value)).ByteArrayToImage();
                lblDichVu.Text = r[0].Cells["Service_Name"].Value.ToString();
                lblGia.Text = r[0].Cells["Service_Price"].Value.ToString();
            }
        }

        private void picDV_Click(object sender, EventArgs e)
        {
            FormChonDichVu f = new FormChonDichVu();
            f.SD += new FormChonDichVu.SendData(GetServiceInfor);
            f.ShowDialog();
        }

        public void GetServiceInfor(int id, string name, double price, Image img)
        {
            picDV.Tag = id;
            lblDichVu.Text = name;
            picDV.Image = img;
            lblGia.Text = price.ToString();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _db.AddServiceOrder(new ServiceOrderVM
                {
                    Bill_Id = _currentBillId,
                    Service_Id = Convert.ToInt32(picDV.Tag),
                    Count = Convert.ToInt32(NUDSoLuong.Value),
                    Total = Convert.ToDouble(lblGia.Text) * Convert.ToInt32(NUDSoLuong.Value)
                });
                new FormAlert("Đặt dịch vụ thành công", Success);
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
                DataGridViewSelectedRowCollection r = dgvDV.SelectedRows;
                _db.UpdateServiceOrder(new ServiceOrderVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Bill_Id = _currentBillId,
                    Service_Id = Convert.ToInt32(picDV.Tag),
                    Count = Convert.ToInt32(NUDSoLuong.Value),
                    Total = Convert.ToDouble(lblGia.Text) * Convert.ToInt32(NUDSoLuong.Value)
                });
                new FormAlert("Sửa thông tin thành công", Success);
                LoadData();
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDV.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteServiceOrder(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    new FormAlert("Xoá đặt dịch vụ thành công", Success);
                }
            }
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
    }
}
