using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LoadData();
            _db.GetComboBoxCustomer(cbbKhachHang);
            currentCashier_Id = (new AccountInformationRepository())
                            .GetAIByAccountId(FormLogin.currentAccount_Id).Id;
        }
        private void LoadData()
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
            LoadData();
        }
    }
}
