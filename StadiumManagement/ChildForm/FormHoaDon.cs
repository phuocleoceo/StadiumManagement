using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUILayer.ChildForm.SubForm;

namespace GUILayer.ChildForm
{
    public partial class FormHoaDon : Form
    {
        private readonly BillRepository _db;
        private readonly int currentCashier_Id;
        public FormHoaDon()
        {
            InitializeComponent();
            dgvBill.FormatTable();
            _db = new BillRepository();
            LoadBillData();
            _db.GetComboBoxCustomer(cbbKhachHang);
            currentCashier_Id = (new AccountInformationRepository())
                            .GetAIByAccountId(FormLogin.currentAccount_Id).Id;
        }
        private void LoadBillData()
        {
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetList();
            dgvBill.Columns["Id"].Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNgayTao.Text = txtNgayThanhToan.Text = txtMaHoaDon.Text = txtThuNgan.Text
                = txtTongTien.Text  = cbbKhachHang.Text = "";
        }

        private void dgvBill_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count == 1)
            {
                txtMaHoaDon.Text = r[0].Cells["BillCode"].Value.ToString();
                txtNgayTao.Text = r[0].Cells["DateCreated"].Value.ToString();
                txtThuNgan.Text = r[0].Cells["Cashier_Name"].Value.ToString();
                txtTongTien.Text = r[0].Cells["Total"].Value.ToString();
                cbbKhachHang.Text = r[0].Cells["Customer_Name"].Value.ToString();
                txtSDTKhach.Text = r[0].Cells["Customer_Phone"].Value.ToString();

                if (r[0].Cells["DateCheckedOut"].Value != null)
                    txtNgayThanhToan.Text = r[0].Cells["DateCheckedOut"].Value.ToString();
                else txtNgayThanhToan.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _db.AddBill(new BillVM
            {
                BillCode = txtMaHoaDon.Text,
                Customer_Id = ((CBBItem)cbbKhachHang.SelectedItem).Value,
                Cashier_Id = currentCashier_Id,
                DateCreated = DateTime.Now,
                DateCheckedOut = null,
                Total = 0
            });
            LoadBillData();
        }

        private void btnDatDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            int Bill_Id = (int)r[0].Cells["Id"].Value;
            string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
            FormDatDichVu f = new FormDatDichVu(Bill_Id,Bill_Code);
            f.LDB += new FormDatDichVu.LoadDataBill(LoadBillData);
            f.ShowDialog();
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            int Bill_Id = (int)r[0].Cells["Id"].Value;
            string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
            FormDatSan f = new FormDatSan(Bill_Id, Bill_Code);
            f.LDB += new FormDatSan.LoadDataBill(LoadBillData);
            f.ShowDialog();
        }
    }
}
