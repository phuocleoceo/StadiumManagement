using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;
using GUILayer.ChildForm.SubForm;

namespace GUILayer.ChildForm
{
    public partial class FormDatSan : Form
    {
        private readonly RentOrderRepository _db;
        public FormDatSan()
        {
            InitializeComponent();
            dgvSan.FormatTable();
            _db = new RentOrderRepository();
            LoadData();
            _db.LoadComboBoxBill(cbbHoaDon);
        }

        private void LoadData()
        {
            dgvSan.DataSource = null;
            dgvSan.Rows.Clear();
            dgvSan.DataSource = _db.GetList();
            dgvSan.Columns["Id"].Visible = false;
            dgvSan.Columns["Stadium_Image"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbbHoaDon.Text = txtTienCoc.Text = txtTongTien.Text = "";
            lblSan.Text = "Click to choose ...";
            picSan.Image = null;
            dtpKetThucThue.Value = dtpBatDauThue.Value = DateTime.Now;
            lblGia.Text = "";
            picSan.Tag = "";
        }

        private void dgvSan_SelectionChanged(object sender, EventArgs e)
        {

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
        }
    }
}
