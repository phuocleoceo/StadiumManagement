﻿using BusinessLayer;
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
            List<StadiumVM> listSVM = _db.GetList();
            foreach (StadiumVM svm in listSVM)
            {
                Image img = svm.Image.ByteArrayToImage();
                if (img != null)
                {
                    imgList.Images.Add(img);
                }
                else
                {
                    imgList.Images.Add(new Bitmap(120,120));
                }
                ListViewItem item = new ListViewItem();
                item.Text = $"{svm.Name}\r\n{svm.Price}";
                item.Tag = svm.Id;
                item.ImageIndex = i++;
                lvSan.Items.Add(item);
            }
        }
    }
}
