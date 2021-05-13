using BusinessLayer.Repository;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;
using System.Collections.Generic;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormChiTietBill : Form
    {
        private readonly StatisticRepository _db;
        private readonly BillVM _bvm;
        private readonly List<RentOrderVM> _rovm;
        private readonly List<ServiceOrderVM> _sovm;
        public FormChiTietBill(int Bill_Id)
        {
            InitializeComponent();
            _db = new StatisticRepository();
            _db.GetBillInformation(Bill_Id, out _bvm, out _rovm, out _sovm);
            LoadLabel();
            LoadRentOrder();
            LoadServiceOrder();
        }

        private void LoadLabel()
        {
            lblMaHoaDon.Text = _bvm.BillCode;
            lblNgayLap.Text = _bvm.DateCreated.ToString();
            lblNgayThanhToan.Text = _bvm.DateCheckedOut.ToString();
            lblTenKhachHang.Text = _bvm.Customer_Name;
            lblSoDienThoai.Text = _bvm.Customer_Phone;
            lblTenThuNgan.Text = _bvm.Cashier_Name;
            lblTongCong.Text = _bvm.Total.ToString();
            lblDaCoc.Text = _bvm.Deposit.ToString();
            lblPhaiTra.Text = (_bvm.Total - _bvm.Deposit).ToString();
        }

        private void LoadRentOrder()
        {
            dgvSan.FormatTable();
            dgvSan.DataSource = _rovm;
            dgvSan.Columns["Id"].Visible = false;
            dgvSan.Columns["Bill_Code"].Visible = false;
            dgvSan.Columns["Stadium_Image"].Visible = false;
            dgvSan.Columns["Stadium_Id"].Visible = false;
            dgvSan.RowsDefaultCellStyle.SelectionBackColor = dgvSan.DefaultCellStyle.BackColor;
            dgvSan.RowsDefaultCellStyle.SelectionForeColor = dgvSan.DefaultCellStyle.ForeColor;
        }

        private void LoadServiceOrder()
        {
            dgvDV.FormatTable();
            dgvDV.DataSource = _sovm;
            dgvDV.Columns["Id"].Visible = false;
            dgvDV.Columns["Bill_Code"].Visible = false;
            dgvDV.Columns["Service_Image"].Visible = false;
            dgvDV.Columns["Service_Id"].Visible = false;
            dgvDV.RowsDefaultCellStyle.SelectionBackColor = dgvSan.DefaultCellStyle.BackColor;
            dgvDV.RowsDefaultCellStyle.SelectionForeColor = dgvSan.DefaultCellStyle.ForeColor;
        }
    }
}
