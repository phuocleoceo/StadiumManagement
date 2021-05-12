using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUILayer.ChildForm.SubForm;

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
        }
        // Lich su Bill
        private void LoadData(DateTime? _fromDate = null, DateTime? _toDate = null)
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetBillHistory(_fromDate, _toDate);
            dgvBill.Columns["Id"].Visible = false;
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
        }
    }
}
