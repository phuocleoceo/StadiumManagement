using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUILayer.ChildForm.SubForm;
using System.Collections.Generic;

namespace GUILayer.ChildForm
{
    public partial class FormThongKe : Form
    {
        private readonly StatisticRepository _db;
        public FormThongKe()
        {
            InitializeComponent();
            dgvBill.FormatTable();
            _db = new StatisticRepository();
            LoadData();
            CalculateSales();
        }
        #region Lich su Bill
        private void LoadData(DateTime? _fromDate = null, DateTime? _toDate = null, string CustomerName = "")
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetBillHistory(_fromDate, _toDate, CustomerName);
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
            LoadData(_fromDate, _toDate);
            CalculateSales();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(null, null, txtSearch.Text);
        }
        #endregion

        #region ThongKeSoLieu
        // Khi chuyen sang tab2 , tab2 xu ly nhieu nen khi chon moi load du lieu
        private void TCThongKe_Selected(object sender, TabControlEventArgs e)
        {
            ThongKeThangVaHomNay();
            DoanhThuTungThang();
            btnSan_Click(new object(), new EventArgs());
        }

        private void ThongKeThangVaHomNay()
        {
            int _billMonth, _billToday, _cusMonth, _cusToday;
            double _saleMonth, _saleToday;
            _db.StatisticMonthAndToday(out _billMonth, out _billToday, out _cusMonth,
                                        out _cusToday, out _saleMonth, out _saleToday);
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
            chartDoanhThu.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisY.Title = "VND";

            double[] _doanhThuThang;
            _db.StatisticSalePerMonth(out _doanhThuThang);
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
            chartSanDV.Series["SanDV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartSanDV.Series["SanDV"].IsValueShownAsLabel = true;
            chartSanDV.ChartAreas["ChartSDVArea"].AxisX.Title = "Sân";
            chartSanDV.ChartAreas["ChartSDVArea"].AxisY.Title = "Thời lượng";
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            chartSanDV.Series["SanDV"].Points.Clear();
            chartSanDV.DataSource = _db.StatisticService();
            chartSanDV.Series["SanDV"].XValueMember = "Name";
            chartSanDV.Series["SanDV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartSanDV.Series["SanDV"].YValueMembers = "Count";
            chartSanDV.Series["SanDV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartSanDV.Series["SanDV"].IsValueShownAsLabel = true;
            chartSanDV.ChartAreas["ChartSDVArea"].AxisX.Title = "Dịch vụ";
            chartSanDV.ChartAreas["ChartSDVArea"].AxisY.Title = "Số lượng";
        }
        #endregion
    }
}
