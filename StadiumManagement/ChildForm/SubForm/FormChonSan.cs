using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormChonSan : Form
    {
        private readonly StadiumRepository _db;
        public FormChonSan()
        {
            InitializeComponent();
            _db = new StadiumRepository();
            LoadListView();
        }

        private void LoadListView()
        {
            int i = 0;
            IEnumerable<StadiumVM> listSVM = _db.GetListAvailable();
            foreach (StadiumVM svm in listSVM)
            {
                Image img = svm.Image.ByteArrayToImage();
                if (img != null)
                {
                    imgList.Images.Add(img);
                }
                else
                {
                    imgList.Images.Add(new Bitmap(120, 120));
                }
                ListViewItem item = new ListViewItem
                {
                    Text = $"{svm.Name}\r\n{svm.Price}",
                    Tag = svm.Id,
                    ImageIndex = i++
                };
                lvSan.Items.Add(item);
            }
        }

        public delegate void SendData(int id, string name, double price, Image img);
        public SendData SD { get; set; }
        private void lvSan_Click(object sender, EventArgs e)
        {
            int id = (int)lvSan.SelectedItems[0].Tag;
            Image img = imgList.Images[lvSan.SelectedItems[0].ImageIndex];
            string[] NP = lvSan.SelectedItems[0].Text.Split('\n');
            string name = NP[0];
            double price = Convert.ToDouble(NP[1]);
            SD(id, name, price, img);
            this.Dispose();
        }
    }
}
