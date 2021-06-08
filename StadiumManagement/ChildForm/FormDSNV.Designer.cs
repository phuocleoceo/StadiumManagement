
namespace GUILayer.ChildForm
{
    partial class FormDSNV
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
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbTaiKhoan = new System.Windows.Forms.ComboBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenNhanVien = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCMND = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLuong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoDienThoai = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.rdbNam = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbNu = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(23, 202);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.Size = new System.Drawing.Size(1006, 347);
            this.dgvDSNV.TabIndex = 1;
            this.dgvDSNV.SelectionChanged += new System.EventHandler(this.dgvDSNV_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(295, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính : ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(515, 36);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 21);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // cbbTaiKhoan
            // 
            this.cbbTaiKhoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTaiKhoan.FormattingEnabled = true;
            this.cbbTaiKhoan.Location = new System.Drawing.Point(859, 86);
            this.cbbTaiKhoan.Name = "cbbTaiKhoan";
            this.cbbTaiKhoan.Size = new System.Drawing.Size(156, 28);
            this.cbbTaiKhoan.TabIndex = 22;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(897, 174);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(749, 140);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(71, 36);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(640, 140);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(71, 36);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(537, 140);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(71, 36);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(433, 140);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(71, 36);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(927, 173);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 67;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 69;
            this.materialLabel2.Text = "Tên nhân viên :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Depth = 0;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Hint = "";
            this.txtTenNhanVien.Location = new System.Drawing.Point(145, 31);
            this.txtTenNhanVien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.SelectionLength = 0;
            this.txtTenNhanVien.SelectionStart = 0;
            this.txtTenNhanVien.Size = new System.Drawing.Size(200, 23);
            this.txtTenNhanVien.TabIndex = 68;
            this.txtTenNhanVien.UseSystemPasswordChar = false;
            // 
            // txtCMND
            // 
            this.txtCMND.Depth = 0;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Hint = "";
            this.txtCMND.Location = new System.Drawing.Point(145, 71);
            this.txtCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.SelectedText = "";
            this.txtCMND.SelectionLength = 0;
            this.txtCMND.SelectionStart = 0;
            this.txtCMND.Size = new System.Drawing.Size(129, 23);
            this.txtCMND.TabIndex = 70;
            this.txtCMND.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(47, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 73;
            this.materialLabel1.Text = "Lương :";
            // 
            // txtLuong
            // 
            this.txtLuong.Depth = 0;
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Hint = "";
            this.txtLuong.Location = new System.Drawing.Point(145, 116);
            this.txtLuong.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.SelectionLength = 0;
            this.txtLuong.SelectionStart = 0;
            this.txtLuong.Size = new System.Drawing.Size(129, 23);
            this.txtLuong.TabIndex = 72;
            this.txtLuong.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(432, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 75;
            this.materialLabel3.Text = "SĐT :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Depth = 0;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Hint = "";
            this.txtSoDienThoai.Location = new System.Drawing.Point(511, 86);
            this.txtSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.SelectionLength = 0;
            this.txtSoDienThoai.SelectionStart = 0;
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 23);
            this.txtSoDienThoai.TabIndex = 74;
            this.txtSoDienThoai.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(421, 37);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(83, 19);
            this.materialLabel4.TabIndex = 77;
            this.materialLabel4.Text = "Ngày sinh :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(770, 41);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 79;
            this.materialLabel5.Text = "Địa chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Hint = "";
            this.txtDiaChi.Location = new System.Drawing.Point(859, 37);
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(156, 23);
            this.txtDiaChi.TabIndex = 78;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(745, 90);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(108, 19);
            this.materialLabel6.TabIndex = 81;
            this.materialLabel6.Text = "Tên tài khoản :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(48, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(61, 19);
            this.materialLabel7.TabIndex = 83;
            this.materialLabel7.Text = "CMND :";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Depth = 0;
            this.rdbNam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNam.Location = new System.Drawing.Point(12, 27);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Ripple = true;
            this.rdbNam.Size = new System.Drawing.Size(58, 30);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Depth = 0;
            this.rdbNu.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNu.Location = new System.Drawing.Point(12, 60);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Ripple = true;
            this.rdbNu.Size = new System.Drawing.Size(47, 30);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // FormDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbbTaiKhoan);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "FormDSNV";
            this.Text = "Danh sách nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbTaiKhoan;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenNhanVien;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCMND;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLuong;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoDienThoai;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRadioButton rdbNu;
        private MaterialSkin.Controls.MaterialRadioButton rdbNam;
    }
}