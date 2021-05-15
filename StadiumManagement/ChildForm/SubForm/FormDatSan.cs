using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormDatSan : Form
    {
        private RentOrderRepository _db;
        private readonly int _currentBillId;
        public FormDatSan(int Bill_Id, string Bill_Code)
        {
            InitializeComponent();
            this.ControlBox = false;
            txtHoaDon.Text = Bill_Code;
            _currentBillId = Bill_Id;
            dgvSan.FormatTable();
            LoadData();
        }

        private void LoadData()
        {
            _db = new RentOrderRepository();
            dgvSan.DataSource = null;
            dgvSan.Rows.Clear();
            dgvSan.DataSource = _db.GetList(_currentBillId);
            dgvSan.Columns["Id"].Visible = false;
            dgvSan.Columns["Stadium_Image"].Visible = false;
            dgvSan.Columns["Stadium_Price"].Visible = false;
            dgvSan.Columns["Stadium_Id"].Visible = false;
            dgvSan.Columns["Bill_Code"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTienCoc.Text = txtTongTien.Text = "";
            dtpKetThucThue.Value = dtpBatDauThue.Value = DateTime.Now;
            lblSan.Text = "Click to choose ...";
            lblGia.Text = "";
            picSan.Image = null;
            picSan.Tag = "";
            btnTrangThai.Visible = false;
        }

        private void dgvSan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvSan.SelectedRows;
            if (r.Count == 1)
            {
                txtTongTien.Text = r[0].Cells["Total"].Value.ToString();
                txtTienCoc.Text = r[0].Cells["Deposit"].Value.ToString();
                dtpBatDauThue.Value = Convert.ToDateTime(r[0].Cells["StartRentDate"].Value);
                dtpKetThucThue.Value = Convert.ToDateTime(r[0].Cells["EndRentDate"].Value);
                picSan.Tag = r[0].Cells["Stadium_Id"].Value;
                picSan.Image = ((byte[])r[0].Cells["Stadium_Image"].Value).ByteArrayToImage();
                lblSan.Text = r[0].Cells["Stadium_Name"].Value.ToString();
                lblGia.Text = r[0].Cells["Stadium_Price"].Value.ToString();
            }
        }

        private void picSan_Click(object sender, EventArgs e)
        {
            FormChonSan f = new FormChonSan();
            f.SD += new FormChonSan.SendData(GetStadiumInfor);
            f.ShowDialog();
        }

        public void GetStadiumInfor(int id, string name, double price, Image img)
        {
            picSan.Tag = id;
            lblSan.Text = name;
            picSan.Image = img;
            lblGia.Text = price.ToString();
            btnTrangThai.Visible = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                RentOrderVM rovm = new RentOrderVM
                {
                    Bill_Id = _currentBillId,
                    Stadium_Id = Convert.ToInt32(picSan.Tag),
                    StartRentDate = dtpBatDauThue.Value,
                    EndRentDate = dtpKetThucThue.Value,
                    Deposit = Convert.ToDouble(txtTienCoc.Text),
                    Total = 0
                };
                rovm.Total = Convert.ToDouble(lblGia.Text) * rovm.RentTime;
                _db.AddRentOrder(rovm);
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thêm được", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection r = dgvSan.SelectedRows;
                RentOrderVM rovm = new RentOrderVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Bill_Id = _currentBillId,
                    Stadium_Id = Convert.ToInt32(picSan.Tag),
                    StartRentDate = dtpBatDauThue.Value,
                    EndRentDate = dtpKetThucThue.Value,
                    Deposit = Convert.ToDouble(txtTienCoc.Text),
                    Total = 0
                };
                rovm.Total = Convert.ToDouble(lblGia.Text) * rovm.RentTime;
                _db.UpdateRentOrder(rovm);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không sửa được", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvSan.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteRentOrder(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                }
            }
            LoadData();
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(picSan.Tag);
            MessageBox.Show(_db.ListRentTime(id),"Sân đã được đặt lúc : ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

