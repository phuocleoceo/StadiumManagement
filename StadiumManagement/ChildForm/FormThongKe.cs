using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.LinearRegression;
using GUILayer.ChildForm.SubForm;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormThongKe : Form
    {
        private readonly StatisticRepository _db;
        private LinearRegression _lr;
        public FormThongKe()
        {
            InitializeComponent();
            dgvBill.FormatTable();
            dgvKhachTB.FormatMiniTable();
            _db = new StatisticRepository();
            LoadData();
            CalculateSales();
        }
        #region Lich su Bill
        private void LoadData(string CustomerName = "", DateTime? _fromDate = null,
                                DateTime? _toDate = null)
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetBillHistory(CustomerName, _fromDate, _toDate).ToSortableBindingList();
            dgvBill.Columns["Id"].Visible = false;
        }

        private void CalculateSales()
        {
            double _sale = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                _sale += Convert.ToDouble(row.Cells["Total"].Value);
            }
            lblTongDoanhTHu.Text = _sale.ToString();
        }

        private void dgvBill_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            FormChiTietBill f = new FormChiTietBill(Convert.ToInt32(r[0].Cells["Id"].Value));
            f.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime? _fromDate = dtpFromDate.Value;
            DateTime? _toDate = dtpToDate.Value;
            LoadData("", _fromDate, _toDate);
            CalculateSales();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }
        #endregion

        #region ThongKeSoLieu
        // Khi chuyen sang tab2 , tab2 xu ly nhieu nen khi chon moi load du lieu
        private void TPSoLieu_Enter(object sender, EventArgs e)
        {
            ThongKeThangVaHomNay();
            DoanhThuTungThang();
            btnSan_Click(new object(), new EventArgs());
        }

        private void ThongKeThangVaHomNay()
        {
            _db.StatisticMonthAndToday(out int _billMonth, out int _billToday,
                                       out int _cusMonth, out int _cusToday,
                                       out double _saleMonth, out double _saleToday);
            lblHoaDonThang.Text = _billMonth.ToString();
            lblHoaDonHomNay.Text = _billToday.ToString();
            lblKhachHangThang.Text = _cusMonth.ToString();
            lblKhachHangHomNay.Text = _cusToday.ToString();
            lblDoanhThuThang.Text = _saleMonth.ToString();
            lblDoanhThuHomNay.Text = _saleToday.ToString();
        }

        private void DoanhThuTungThang()
        {
            chartDoanhThu.Series["Doanh thu"].Points.Clear();
            chartDoanhThu.Series["Doanh thu"]["PixelPointWidth"] = "20";
            chartDoanhThu.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisY.Title = "VND";

            _db.StatisticSalePerMonth(out double[] _doanhThuThang);
            for (int i = 1; i <= 12; i++)
            {
                chartDoanhThu.Series["Doanh thu"].Points.AddXY(i, _doanhThuThang[i]);
            }
        }

        private void btnSan_Click(object sender, EventArgs e)
        {
            chartSanDV.Series["SanDV"].Points.Clear();
            chartSanDV.DataSource = _db.StatisticStadium();
            chartSanDV.Series["SanDV"].XValueMember = "Name";
            chartSanDV.Series["SanDV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartSanDV.Series["SanDV"].YValueMembers = "Count";
            chartSanDV.Series["SanDV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartSanDV.Series["SanDV"].IsValueShownAsLabel = true;
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            chartSanDV.Series["SanDV"].Points.Clear();
            chartSanDV.DataSource = _db.StatisticService();
            chartSanDV.Series["SanDV"].XValueMember = "Name";
            chartSanDV.Series["SanDV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartSanDV.Series["SanDV"].YValueMembers = "Count";
            chartSanDV.Series["SanDV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chartSanDV.Series["SanDV"].IsValueShownAsLabel = true;
        }
        #endregion

        #region PhanTichDoanhThu
        private void TPDuDoan_Enter(object sender, EventArgs e)
        {
            _lr = new LinearRegression();
            DuDoanDoanhThu();
            PhuongTrinhHoiQuy();
            KhachHangTrungBinh();
        }
        private void PhuongTrinhHoiQuy()
        {
            _lr.CalculateCoefficient(out double a, out double b);
            a = Math.Round(a);
            b = Math.Round(b);
            lblPhuongTrinh.Text = $"Phương trình hồi quy : Doanh Thu = Số Khách * {a} + {b}";
        }
        private void DuDoanDoanhThu()
        {
            chartDuDoan.Series["Doanh thu"].Points.Clear();
            chartDuDoan.Series["Doanh thu"]["PixelPointWidth"] = "40";
            chartDuDoan.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartDuDoan.ChartAreas["ChartDuDoan"].AxisX.Title = "Ngày";
            chartDuDoan.ChartAreas["ChartDuDoan"].AxisY.Title = "VND";

            double[] _predit = _lr.PredictSalePerDayWeek();
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 2", _predit[1]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 3", _predit[2]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 4", _predit[3]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 5", _predit[4]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 6", _predit[5]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 7", _predit[6]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Chủ nhật", _predit[0]);
        }
        private void KhachHangTrungBinh()
        {
            dgvKhachTB.Rows.Clear();
            SortableBindingList<double> list = (new GetData()).GetAverageCustomer().ToSortableBindingList();
            dgvKhachTB.Rows.Add(new string[] { "Thứ 2", list[1].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 3", list[2].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 4", list[3].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 5", list[4].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 6", list[5].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 7", list[6].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Chủ nhật", list[0].ToString() });
        }
        #endregion
    }
}
