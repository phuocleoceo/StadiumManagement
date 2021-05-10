using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormChonDichVu : Form
    {
        private readonly ServiceRepository _db;
        public FormChonDichVu()
        {
            InitializeComponent();
            _db = new ServiceRepository();
            LoadListView();
        }

        private void LoadListView()
        {
            int i = 0;
            List<ServiceVM> listSVM = _db.GetList();
            foreach(ServiceVM svm in listSVM)
            {
                imgList.Images.Add(svm.Image.ByteArrayToImage());
                ListViewItem item = new ListViewItem();
                item.Text = $"{svm.Name}\r\n{svm.Price}";
                item.Tag = svm.Id;
                item.ImageIndex = i;
                i++;
                lvDV.Items.Add(item);
            }
        }
    }
}
