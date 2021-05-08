using BusinessLayer.Repository;
using System;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using BusinessLayer;

namespace GUILayer.ChildForm
{
    public partial class FormDatDichVu : Form
    {
        private readonly ServiceOrderRepository _db;
        public FormDatDichVu()
        {
            InitializeComponent();
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
        }
    }
}
