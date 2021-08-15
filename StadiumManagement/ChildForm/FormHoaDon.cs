using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using GUILayer.ChildForm.SubForm;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static GUILayer.AlertType;

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
        private void LoadData(string CustomerName = "")
        {
            // Reset DbContext
            _db = new BillRepository();
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = _db.GetList(CustomerName).ToSortableBindingList();
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
            txtNgayTao.Text = txtMaHoaDon.Text = txtThuNgan.Text = txtTongTien.Text
                = cbbKhachHang.Text = txtSDTKhach.Text = txtTienCoc.Text = txtPhaiTra.Text = "";
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
            try
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
                new FormAlert("Thêm hoá đơn thành công", Success);
                LoadData();
            }
            catch (Exception ex)
            {
                new FormAlert(ex.Message, Infor);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        _db.DeleteBill(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    new FormAlert("Xoá hoá đơn thành công", Success);
                }
            }
            LoadData();
        }

        private void btnDatDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count == 1)
            {
                int Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
                string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
                FormDatDichVu f = new FormDatDichVu(Bill_Id, Bill_Code);
                f.ShowDialog();
                SetBillTotal();
                LoadData();
            }
            else
            {
                new FormAlert("Chưa chọn hoá đơn", Warning);
            }
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count == 1)
            {
                int Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
                string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
                FormDatSan f = new FormDatSan(Bill_Id, Bill_Code);
                f.ShowDialog();
                SetBillTotal();
                LoadData();
            }
            else
            {
                new FormAlert("Chưa chọn hoá đơn", Warning);
            }
        }

        private int _Bill_Id;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            if (r.Count == 1)
            {
                _Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
                string SanChuaSuDungXong = _db.UnFinishedStadium(_Bill_Id);
                if (SanChuaSuDungXong.Length == 0)
                {
                    ThanhToan();
                }
                else if (MessageBox.Show($"Các sân sau chưa sử dụng xong :\r\n{SanChuaSuDungXong}\nVẫn xác nhận thanh toán ?",
                        "Cân nhắc !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ThanhToan();
                }
            }
            else
            {
                new FormAlert("Chưa chọn hoá đơn !", Warning);
            }
        }

        private void ThanhToan()
        {
            if (MessageBox.Show("In hoá đơn không ?", "Cân nhắc !",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PrintBill();
            }
            _db.PurchaseBill(_Bill_Id);
            new FormAlert("Thanh toán thành công", Success);
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
                new FormAlert("Không in được !", Error);
            }
        }

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string content = _db.GetContentPrint(_Bill_Id);
            e.Graphics.DrawString(content, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            new FormAlert("In hoá đơn thành công", Success);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void iconDice_Click(object sender, EventArgs e)
        {
            StringBuilder code = new StringBuilder();
            Random rd = new Random();
            string tmp1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string tmp2 = "0123456789";
            for (int i = 0; i < 3; i++)
            {
                code.Append(tmp1[rd.Next(0, 25)]);
            }
            for (int i = 0; i < 3; i++)
            {
                code.Append(tmp2[rd.Next(0, 9)]);
            }
            txtMaHoaDon.Text = code.ToString();
        }
    }
}
