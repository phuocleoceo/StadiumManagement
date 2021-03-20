
namespace GUILayer
{
    partial class FormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnsetting = new FontAwesome.Sharp.IconButton();
            this.PanelDropDownSP = new System.Windows.Forms.Panel();
            this.iconButtonSPDonvi = new FontAwesome.Sharp.IconButton();
            this.iconButtonSPLoai = new FontAwesome.Sharp.IconButton();
            this.iconButtonSP = new FontAwesome.Sharp.IconButton();
            this.btndashboard = new FontAwesome.Sharp.IconButton();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.btntonkho = new FontAwesome.Sharp.IconButton();
            this.btnorders = new FontAwesome.Sharp.IconButton();
            this.btnhome = new FontAwesome.Sharp.IconButton();
            this.btnnhapkho = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.labelcon = new System.Windows.Forms.Label();
            this.iconmenusmall = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.paneltrangcon = new System.Windows.Forms.Panel();
            this.lbDateBig = new System.Windows.Forms.Label();
            this.lbNgayThangBig = new System.Windows.Forms.Label();
            this.labelGioBig = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.PanelDropDownSP.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).BeginInit();
            this.paneltrangcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.btnsetting);
            this.PanelMenu.Controls.Add(this.PanelDropDownSP);
            this.PanelMenu.Controls.Add(this.btndashboard);
            this.PanelMenu.Controls.Add(this.btnlogout);
            this.PanelMenu.Controls.Add(this.btntonkho);
            this.PanelMenu.Controls.Add(this.btnorders);
            this.PanelMenu.Controls.Add(this.btnhome);
            this.PanelMenu.Controls.Add(this.btnnhapkho);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(170, 600);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // btnsetting
            // 
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnsetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsetting.IconSize = 35;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 500);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnsetting.Size = new System.Drawing.Size(170, 50);
            this.btnsetting.TabIndex = 8;
            this.btnsetting.Text = "Thiết lập";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // PanelDropDownSP
            // 
            this.PanelDropDownSP.Controls.Add(this.iconButtonSPDonvi);
            this.PanelDropDownSP.Controls.Add(this.iconButtonSPLoai);
            this.PanelDropDownSP.Controls.Add(this.iconButtonSP);
            this.PanelDropDownSP.Location = new System.Drawing.Point(0, 350);
            this.PanelDropDownSP.Name = "PanelDropDownSP";
            this.PanelDropDownSP.Size = new System.Drawing.Size(170, 50);
            this.PanelDropDownSP.TabIndex = 5;
            // 
            // iconButtonSPDonvi
            // 
            this.iconButtonSPDonvi.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonSPDonvi.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSPDonvi.FlatAppearance.BorderSize = 0;
            this.iconButtonSPDonvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSPDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSPDonvi.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSPDonvi.IconChar = FontAwesome.Sharp.IconChar.WeightHanging;
            this.iconButtonSPDonvi.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSPDonvi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSPDonvi.IconSize = 35;
            this.iconButtonSPDonvi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSPDonvi.Location = new System.Drawing.Point(0, 100);
            this.iconButtonSPDonvi.Name = "iconButtonSPDonvi";
            this.iconButtonSPDonvi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSPDonvi.Size = new System.Drawing.Size(170, 50);
            this.iconButtonSPDonvi.TabIndex = 6;
            this.iconButtonSPDonvi.Text = "Đơn vị";
            this.iconButtonSPDonvi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSPDonvi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSPDonvi.UseVisualStyleBackColor = false;
            this.iconButtonSPDonvi.Click += new System.EventHandler(this.iconButtonSPDonvi_Click);
            // 
            // iconButtonSPLoai
            // 
            this.iconButtonSPLoai.BackColor = System.Drawing.Color.Indigo;
            this.iconButtonSPLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSPLoai.FlatAppearance.BorderSize = 0;
            this.iconButtonSPLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSPLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSPLoai.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSPLoai.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.iconButtonSPLoai.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSPLoai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSPLoai.IconSize = 35;
            this.iconButtonSPLoai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSPLoai.Location = new System.Drawing.Point(0, 50);
            this.iconButtonSPLoai.Name = "iconButtonSPLoai";
            this.iconButtonSPLoai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSPLoai.Size = new System.Drawing.Size(170, 50);
            this.iconButtonSPLoai.TabIndex = 5;
            this.iconButtonSPLoai.Text = "Loại";
            this.iconButtonSPLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSPLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSPLoai.UseVisualStyleBackColor = false;
            this.iconButtonSPLoai.Click += new System.EventHandler(this.iconButtonSPLoai_Click);
            // 
            // iconButtonSP
            // 
            this.iconButtonSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSP.FlatAppearance.BorderSize = 0;
            this.iconButtonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSP.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSP.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButtonSP.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSP.IconSize = 35;
            this.iconButtonSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSP.Location = new System.Drawing.Point(0, 0);
            this.iconButtonSP.Name = "iconButtonSP";
            this.iconButtonSP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSP.Size = new System.Drawing.Size(170, 50);
            this.iconButtonSP.TabIndex = 4;
            this.iconButtonSP.Text = "Sản phẩm";
            this.iconButtonSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSP.UseVisualStyleBackColor = true;
            this.iconButtonSP.Click += new System.EventHandler(this.iconButtonSP_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btndashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndashboard.IconSize = 35;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 300);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btndashboard.Size = new System.Drawing.Size(170, 50);
            this.btndashboard.TabIndex = 4;
            this.btndashboard.Text = "Thống kê";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnlogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.IconSize = 35;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 550);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnlogout.Size = new System.Drawing.Size(170, 50);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Đăng xuất";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btntonkho
            // 
            this.btntonkho.FlatAppearance.BorderSize = 0;
            this.btntonkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntonkho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btntonkho.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btntonkho.IconColor = System.Drawing.Color.Gainsboro;
            this.btntonkho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntonkho.IconSize = 35;
            this.btntonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntonkho.Location = new System.Drawing.Point(0, 250);
            this.btntonkho.Name = "btntonkho";
            this.btntonkho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btntonkho.Size = new System.Drawing.Size(170, 50);
            this.btntonkho.TabIndex = 6;
            this.btntonkho.Text = "Tồn kho";
            this.btntonkho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntonkho.UseVisualStyleBackColor = true;
            this.btntonkho.Click += new System.EventHandler(this.btnluong_Click);
            // 
            // btnorders
            // 
            this.btnorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnorders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnorders.IconColor = System.Drawing.Color.Gainsboro;
            this.btnorders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnorders.IconSize = 35;
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(0, 150);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnorders.Size = new System.Drawing.Size(170, 50);
            this.btnorders.TabIndex = 2;
            this.btnorders.Text = "Đơn Hàng";
            this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnhome
            // 
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnhome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhome.IconSize = 35;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 100);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnhome.Size = new System.Drawing.Size(170, 50);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "Trang chủ";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnnhapkho
            // 
            this.btnnhapkho.FlatAppearance.BorderSize = 0;
            this.btnnhapkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhapkho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnnhapkho.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnnhapkho.IconColor = System.Drawing.Color.Gainsboro;
            this.btnnhapkho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnhapkho.IconSize = 35;
            this.btnnhapkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhapkho.Location = new System.Drawing.Point(0, 200);
            this.btnnhapkho.Name = "btnnhapkho";
            this.btnnhapkho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnnhapkho.Size = new System.Drawing.Size(170, 50);
            this.btnnhapkho.TabIndex = 5;
            this.btnnhapkho.Text = "Nhập kho";
            this.btnnhapkho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhapkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnhapkho.UseVisualStyleBackColor = true;
            this.btnnhapkho.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.picLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(170, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUILayer.Properties.Resources.logo200;
            this.picLogo.Location = new System.Drawing.Point(30, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(105, 97);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.lbDateTime);
            this.panelTitlebar.Controls.Add(this.LabelUser);
            this.panelTitlebar.Controls.Add(this.iconMinimize);
            this.panelTitlebar.Controls.Add(this.iconZoom);
            this.panelTitlebar.Controls.Add(this.iconExit);
            this.panelTitlebar.Controls.Add(this.labelcon);
            this.panelTitlebar.Controls.Add(this.iconmenusmall);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(170, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(930, 70);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateTime.Location = new System.Drawing.Point(366, 31);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 20);
            this.lbDateTime.TabIndex = 6;
            this.lbDateTime.Text = "12:30:33";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelUser.Location = new System.Drawing.Point(184, 31);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(87, 16);
            this.LabelUser.TabIndex = 5;
            this.LabelUser.Text = "phuocleoceo";
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(832, 2);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(30, 30);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconZoom
            // 
            this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconZoom.IconSize = 25;
            this.iconZoom.Location = new System.Drawing.Point(867, 7);
            this.iconZoom.Name = "iconZoom";
            this.iconZoom.Size = new System.Drawing.Size(30, 30);
            this.iconZoom.TabIndex = 3;
            this.iconZoom.UseVisualStyleBackColor = true;
            this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(895, 7);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(30, 30);
            this.iconExit.TabIndex = 2;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelcon.Location = new System.Drawing.Point(64, 31);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(45, 16);
            this.labelcon.TabIndex = 1;
            this.labelcon.Text = "Home";
            // 
            // iconmenusmall
            // 
            this.iconmenusmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconmenusmall.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconmenusmall.IconColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenusmall.Location = new System.Drawing.Point(19, 23);
            this.iconmenusmall.Name = "iconmenusmall";
            this.iconmenusmall.Size = new System.Drawing.Size(32, 32);
            this.iconmenusmall.TabIndex = 0;
            this.iconmenusmall.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelshadow.Location = new System.Drawing.Point(173, 64);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(628, 9);
            this.panelshadow.TabIndex = 2;
            // 
            // paneltrangcon
            // 
            this.paneltrangcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.paneltrangcon.Controls.Add(this.lbDateBig);
            this.paneltrangcon.Controls.Add(this.lbNgayThangBig);
            this.paneltrangcon.Controls.Add(this.labelGioBig);
            this.paneltrangcon.Location = new System.Drawing.Point(170, 67);
            this.paneltrangcon.Name = "paneltrangcon";
            this.paneltrangcon.Size = new System.Drawing.Size(930, 533);
            this.paneltrangcon.TabIndex = 3;
            this.paneltrangcon.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltrangcon_Paint);
            // 
            // lbDateBig
            // 
            this.lbDateBig.AutoSize = true;
            this.lbDateBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateBig.Location = new System.Drawing.Point(588, 333);
            this.lbDateBig.Name = "lbDateBig";
            this.lbDateBig.Size = new System.Drawing.Size(267, 73);
            this.lbDateBig.TabIndex = 9;
            this.lbDateBig.Text = "monday";
            // 
            // lbNgayThangBig
            // 
            this.lbNgayThangBig.AutoSize = true;
            this.lbNgayThangBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThangBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNgayThangBig.Location = new System.Drawing.Point(56, 333);
            this.lbNgayThangBig.Name = "lbNgayThangBig";
            this.lbNgayThangBig.Size = new System.Drawing.Size(366, 73);
            this.lbNgayThangBig.TabIndex = 8;
            this.lbNgayThangBig.Text = "04/07/2020";
            // 
            // labelGioBig
            // 
            this.labelGioBig.AutoSize = true;
            this.labelGioBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioBig.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGioBig.Location = new System.Drawing.Point(305, 166);
            this.labelGioBig.Name = "labelGioBig";
            this.labelGioBig.Size = new System.Drawing.Size(425, 108);
            this.labelGioBig.TabIndex = 7;
            this.labelGioBig.Text = "12:30:33";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.paneltrangcon);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControl";
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelDropDownSP.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).EndInit();
            this.paneltrangcon.ResumeLayout(false);
            this.paneltrangcon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnhome;
        private FontAwesome.Sharp.IconButton btnnhapkho;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconButton btnorders;
        private FontAwesome.Sharp.IconButton btntonkho;
        private FontAwesome.Sharp.IconButton btnlogout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconmenusmall;
        private System.Windows.Forms.Label labelcon;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel paneltrangcon;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconZoom;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Panel PanelDropDownSP;
        private FontAwesome.Sharp.IconButton iconButtonSP;
        private FontAwesome.Sharp.IconButton iconButtonSPDonvi;
        private FontAwesome.Sharp.IconButton iconButtonSPLoai;
        private FontAwesome.Sharp.IconButton btnsetting;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelGioBig;
        private System.Windows.Forms.Label lbNgayThangBig;
        private System.Windows.Forms.Label lbDateBig;
    }
}