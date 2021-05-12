using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUILayer.ChildForm.SubForm;
using System.Drawing;

namespace GUILayer.ChildForm
{
    public partial class FormHoaDon : Form
    {
        private BillRepository _db;
        private readonly int currentCashier_Id;
        public FormHoaDon()
        {
            InitializeComponent();
            dgvBill.FormatTable();
            _db = new BillRepository();
            _db.GetComboBoxCustomer(cbbKhachHang);
            currentCashier_Id = (new AccountInformationRepository()).GetAIByAccountId(FormLogin.currentAccount_Id).Id;
            LoadData();
            //In ngang
            printDocumentBill.DefaultPageSettings.Landscape = true;
        }
        private void LoadData()
        {
            // Reset DbContext
            _db = new BillRepository();
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetList();
            dgvBill.Columns["Id"].Visible = false;
            dgvBill.Columns["DateCheckedOut"].Visible = false;
        }
        private void SetBillTotal()
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            _db.SetTotal(Convert.ToInt32(r[0].Cells["Id"].Value));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNgayTao.Text = txtMaHoaDon.Text = txtThuNgan.Text
                = txtTongTien.Text = cbbKhachHang.Text = txtSDTKhach.Text = "";
        }

        private void dgvBill_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count == 1)
            {
                txtMaHoaDon.Text = r[0].Cells["BillCode"].Value.ToString();
                txtNgayTao.Text = r[0].Cells["DateCreated"].Value.ToString();
                txtThuNgan.Text = r[0].Cells["Cashier_Name"].Value.ToString();
                cbbKhachHang.Text = r[0].Cells["Customer_Name"].Value.ToString();
                txtSDTKhach.Text = r[0].Cells["Customer_Phone"].Value.ToString();

                double TienCoc = Convert.ToDouble(r[0].Cells["Deposit"].Value);
                double TongTien = Convert.ToDouble(r[0].Cells["Total"].Value);
                txtTienCoc.Text = TienCoc.ToString();
                txtTongTien.Text = TongTien.ToString();
                txtPhaiTra.Text = (TongTien - TienCoc).ToString();
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

        private void btnDatDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            int Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
            string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
            FormDatDichVu f = new FormDatDichVu(Bill_Id, Bill_Code);
            f.ShowDialog();
            SetBillTotal();
            LoadData();
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            int Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
            string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
            FormDatSan f = new FormDatSan(Bill_Id, Bill_Code);
            f.ShowDialog();
            SetBillTotal();
            LoadData();
        }

        private int _Bill_Id;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            _Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
            _db.PurchaseBill(_Bill_Id);
            if (MessageBox.Show("In hoá đơn không ?", "Cân nhắc !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrintBill();
            }
            LoadData();
        }

        private void PrintBill()
        {
            try
            {
                printDialogBill.Document = printDocumentBill;
                if (printDialogBill.ShowDialog() == DialogResult.OK)
                {
                    printDocumentBill.Print();
                }
            }
            catch
            {
                MessageBox.Show("Không in được !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string content = _db.GetContentPrint(_Bill_Id);
            e.Graphics.DrawString(content, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 200);
        }
    }
}
