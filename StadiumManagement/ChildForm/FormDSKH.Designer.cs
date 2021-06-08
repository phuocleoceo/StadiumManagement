
namespace GUILayer.ChildForm
{
    partial class FormDSKH
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
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.rdbNu = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbNam = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenKhachHang = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoDienThoai = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Location = new System.Drawing.Point(12, 206);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.Size = new System.Drawing.Size(1005, 360);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.SelectionChanged += new System.EventHandler(this.dgvDSKH_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(89, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(914, 178);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 73;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(736, 146);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(71, 36);
            this.btnClear.TabIndex = 69;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(627, 146);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(71, 36);
            this.btnXoa.TabIndex = 70;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(524, 146);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(71, 36);
            this.btnSua.TabIndex = 71;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(420, 146);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(71, 36);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(884, 179);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 68;
            this.iconPictureBox1.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Depth = 0;
            this.rdbNu.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNu.Location = new System.Drawing.Point(92, 55);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Ripple = true;
            this.rdbNu.Size = new System.Drawing.Size(47, 30);
            this.rdbNu.TabIndex = 74;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Depth = 0;
            this.rdbNam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbNam.Location = new System.Drawing.Point(92, 20);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(0);
            this.rdbNam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Ripple = true;
            this.rdbNam.Size = new System.Drawing.Size(58, 30);
            this.rdbNam.TabIndex = 75;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(48, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(122, 19);
            this.materialLabel2.TabIndex = 75;
            this.materialLabel2.Text = "Tên khách hàng :";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Depth = 0;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Hint = "";
            this.txtTenKhachHang.Location = new System.Drawing.Point(181, 37);
            this.txtTenKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.PasswordChar = '\0';
            this.txtTenKhachHang.SelectedText = "";
            this.txtTenKhachHang.SelectionLength = 0;
            this.txtTenKhachHang.SelectionStart = 0;
            this.txtTenKhachHang.Size = new System.Drawing.Size(193, 23);
            this.txtTenKhachHang.TabIndex = 74;
            this.txtTenKhachHang.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(511, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 77;
            this.materialLabel1.Text = "Số điện thoại :";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Depth = 0;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Hint = "";
            this.txtSoDienThoai.Location = new System.Drawing.Point(627, 37);
            this.txtSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.SelectionLength = 0;
            this.txtSoDienThoai.SelectionStart = 0;
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 23);
            this.txtSoDienThoai.TabIndex = 76;
            this.txtSoDienThoai.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(532, 83);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 79;
            this.materialLabel3.Text = "Địa chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Hint = "";
            this.txtDiaChi.Location = new System.Drawing.Point(627, 79);
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(200, 23);
            this.txtDiaChi.TabIndex = 78;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // FormDSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 577);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSKH);
            this.Name = "FormDSKH";
            this.Text = "Danh sách khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialRadioButton rdbNu;
        private MaterialSkin.Controls.MaterialRadioButton rdbNam;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenKhachHang;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoDienThoai;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
    }
}