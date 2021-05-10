using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;
using System.Drawing;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormDatDichVu : Form
    {
        private readonly ServiceOrderRepository _db;
        public FormDatDichVu(int Bill_Id, string Bill_Code)
        {
            InitializeComponent();
            txtHoaDon.Text = Bill_Code;
            this.Tag = Bill_Id;
            dgvDV.FormatTable();
            _db = new ServiceOrderRepository();
            LoadData();
        }

        private void LoadData()
        {
            dgvDV.DataSource = null;
            dgvDV.Rows.Clear();
            dgvDV.DataSource = _db.GetList();
            dgvDV.Columns["Id"].Visible = false;
            dgvDV.Columns["Service_Image"].Visible = false;
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
                lblDichVu.Text = r[0].Cells["Service_Name"].Value.ToString();
                picDV.Image = ((byte[])(r[0].Cells["Service_Image"].Value)).ByteArrayToImage();
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

        public delegate void LoadDataBill();
        public LoadDataBill LDB { get; set; }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            LDB();
            this.Dispose();
        }
    }
}
