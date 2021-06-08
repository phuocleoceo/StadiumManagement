
namespace GUILayer.ChildForm
{
    partial class FormQLSan
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
            this.dgvDSSan = new System.Windows.Forms.DataGridView();
            this.picSB = new System.Windows.Forms.PictureBox();
            this.grbChoThue = new System.Windows.Forms.GroupBox();
            this.rdbKhong = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbCo = new MaterialSkin.Controls.MaterialRadioButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtTenSan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonGia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnChonAnh = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDienTich = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGhiChu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSB)).BeginInit();
            this.grbChoThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSan
            // 
            this.dgvDSSan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSan.Location = new System.Drawing.Point(20, 206);
            this.dgvDSSan.Name = "dgvDSSan";
            this.dgvDSSan.Size = new System.Drawing.Size(1005, 357);
            this.dgvDSSan.TabIndex = 2;
            this.dgvDSSan.SelectionChanged += new System.EventHandler(this.dgvDSSan_SelectionChanged);
            // 
            // picSB
            // 
            this.picSB.Location = new System.Drawing.Point(849, 19);
            this.picSB.Name = "picSB";
            this.picSB.Size = new System.Drawing.Size(160, 160);
            this.picSB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSB.TabIndex = 55;
            this.picSB.TabStop = false;
            // 
            // grbChoThue
            // 
            this.grbChoThue.Controls.Add(this.rdbKhong);
            this.grbChoThue.Controls.Add(this.rdbCo);
            this.grbChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChoThue.Location = new System.Drawing.Point(373, 24);
            this.grbChoThue.Name = "grbChoThue";
            this.grbChoThue.Size = new System.Drawing.Size(104, 92);
            this.grbChoThue.TabIndex = 57;
            this.grbChoThue.TabStop = false;
            this.grbChoThue.Text = "Cho thuê : ";
            // 
            // rdbKhong
            // 
            this.rdbKhong.AutoSize = true;
            this.rdbKhong.Depth = 0;
            this.rdbKhong.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbKhong.Location = new System.Drawing.Point(3, 55);
            this.rdbKhong.Margin = new System.Windows.Forms.Padding(0);
            this.rdbKhong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbKhong.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbKhong.Name = "rdbKhong";
            this.rdbKhong.Ripple = true;
            this.rdbKhong.Size = new System.Drawing.Size(68, 30);
            this.rdbKhong.TabIndex = 0;
            this.rdbKhong.TabStop = true;
            this.rdbKhong.Text = "Không";
            this.rdbKhong.UseVisualStyleBackColor = true;
            // 
            // rdbCo
            // 
            this.rdbCo.AutoSize = true;
            this.rdbCo.Depth = 0;
            this.rdbCo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbCo.Location = new System.Drawing.Point(3, 24);
            this.rdbCo.Margin = new System.Windows.Forms.Padding(0);
            this.rdbCo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbCo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbCo.Name = "rdbCo";
            this.rdbCo.Ripple = true;
            this.rdbCo.Size = new System.Drawing.Size(46, 30);
            this.rdbCo.TabIndex = 0;
            this.rdbCo.TabStop = true;
            this.rdbCo.Text = "Có";
            this.rdbCo.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(21, 177);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 59;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtTenSan
            // 
            this.txtTenSan.Depth = 0;
            this.txtTenSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSan.Hint = "";
            this.txtTenSan.Location = new System.Drawing.Point(125, 35);
            this.txtTenSan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.PasswordChar = '\0';
            this.txtTenSan.SelectedText = "";
            this.txtTenSan.SelectionLength = 0;
            this.txtTenSan.SelectionStart = 0;
            this.txtTenSan.Size = new System.Drawing.Size(200, 23);
            this.txtTenSan.TabIndex = 60;
            this.txtTenSan.UseSystemPasswordChar = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Depth = 0;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Hint = "";
            this.txtDonGia.Location = new System.Drawing.Point(125, 86);
            this.txtDonGia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.SelectionLength = 0;
            this.txtDonGia.SelectionStart = 0;
            this.txtDonGia.Size = new System.Drawing.Size(200, 23);
            this.txtDonGia.TabIndex = 60;
            this.txtDonGia.UseSystemPasswordChar = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(243, 143);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(71, 36);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(347, 143);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(71, 36);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(450, 143);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(71, 36);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(559, 143);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(71, 36);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.SystemColors.Control;
            this.btnChonAnh.Depth = 0;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(670, 143);
            this.btnChonAnh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Primary = true;
            this.btnChonAnh.Size = new System.Drawing.Size(90, 36);
            this.btnChonAnh.TabIndex = 62;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Depth = 0;
            this.txtDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienTich.Hint = "";
            this.txtDienTich.Location = new System.Drawing.Point(600, 35);
            this.txtDienTich.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.PasswordChar = '\0';
            this.txtDienTich.SelectedText = "";
            this.txtDienTich.SelectionLength = 0;
            this.txtDienTich.SelectionStart = 0;
            this.txtDienTich.Size = new System.Drawing.Size(210, 23);
            this.txtDienTich.TabIndex = 60;
            this.txtDienTich.UseSystemPasswordChar = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Depth = 0;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Hint = "";
            this.txtGhiChu.Location = new System.Drawing.Point(600, 86);
            this.txtGhiChu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.SelectionLength = 0;
            this.txtGhiChu.SelectionStart = 0;
            this.txtGhiChu.Size = new System.Drawing.Size(210, 23);
            this.txtGhiChu.TabIndex = 60;
            this.txtGhiChu.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(513, 40);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 61;
            this.materialLabel3.Text = "Diện tích :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(512, 89);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 61;
            this.materialLabel4.Text = "Ghi chú :";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(52, 177);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Đơn giá :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(46, 39);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 64;
            this.materialLabel2.Text = "Tên sân :";
            // 
            // FormQLSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1041, 573);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtTenSan);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.grbChoThue);
            this.Controls.Add(this.picSB);
            this.Controls.Add(this.dgvDSSan);
            this.Name = "FormQLSan";
            this.Text = "Quản lý sân";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSB)).EndInit();
            this.grbChoThue.ResumeLayout(false);
            this.grbChoThue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSan;
        private System.Windows.Forms.PictureBox picSB;
        private System.Windows.Forms.GroupBox grbChoThue;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenSan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonGia;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnChonAnh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDienTich;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGhiChu;
        private MaterialSkin.Controls.MaterialRadioButton rdbKhong;
        private MaterialSkin.Controls.MaterialRadioButton rdbCo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}