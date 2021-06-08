
namespace GUILayer.ChildForm
{
    partial class FormTaiKhoan
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
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.cbbVaiTro = new System.Windows.Forms.ComboBox();
            this.grbThem = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.picTK = new System.Windows.Forms.PictureBox();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenTaiKhoan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.grbThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Location = new System.Drawing.Point(76, 199);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.Size = new System.Drawing.Size(844, 347);
            this.dgvDSTK.TabIndex = 2;
            this.dgvDSTK.SelectionChanged += new System.EventHandler(this.dgvDSTK_SelectionChanged);
            // 
            // cbbVaiTro
            // 
            this.cbbVaiTro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbVaiTro.FormattingEnabled = true;
            this.cbbVaiTro.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cbbVaiTro.Location = new System.Drawing.Point(739, 58);
            this.cbbVaiTro.Name = "cbbVaiTro";
            this.cbbVaiTro.Size = new System.Drawing.Size(135, 28);
            this.cbbVaiTro.TabIndex = 18;
            // 
            // grbThem
            // 
            this.grbThem.Controls.Add(this.btnCancel);
            this.grbThem.Controls.Add(this.btnOK);
            this.grbThem.Controls.Add(this.txtMatKhau);
            this.grbThem.Location = new System.Drawing.Point(432, 108);
            this.grbThem.Name = "grbThem";
            this.grbThem.Size = new System.Drawing.Size(197, 100);
            this.grbThem.TabIndex = 26;
            this.grbThem.TabStop = false;
            this.grbThem.Text = "Nhập mật khẩu :";
            this.grbThem.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(112, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(23, 59);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(23, 19);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(153, 23);
            this.txtMatKhau.TabIndex = 0;
            // 
            // picTK
            // 
            this.picTK.Location = new System.Drawing.Point(488, 11);
            this.picTK.Name = "picTK";
            this.picTK.Size = new System.Drawing.Size(91, 91);
            this.picTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTK.TabIndex = 56;
            this.picTK.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(656, 128);
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
            this.btnXoa.Location = new System.Drawing.Point(547, 128);
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
            this.btnSua.Location = new System.Drawing.Point(444, 128);
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
            this.btnThem.Location = new System.Drawing.Point(340, 128);
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
            this.txtSearch.Location = new System.Drawing.Point(818, 168);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(787, 168);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 67;
            this.iconPictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(89, 62);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 70;
            this.materialLabel2.Text = "Tên tài khoản :";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Depth = 0;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Hint = "";
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(203, 58);
            this.txtTenTaiKhoan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.SelectionLength = 0;
            this.txtTenTaiKhoan.SelectionStart = 0;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(200, 23);
            this.txtTenTaiKhoan.TabIndex = 69;
            this.txtTenTaiKhoan.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(661, 62);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 70;
            this.materialLabel1.Text = "Vai trò : ";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.grbThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.picTK);
            this.Controls.Add(this.cbbVaiTro);
            this.Controls.Add(this.dgvDSTK);
            this.Name = "FormTaiKhoan";
            this.Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.grbThem.ResumeLayout(false);
            this.grbThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.ComboBox cbbVaiTro;
        private System.Windows.Forms.GroupBox grbThem;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picTK;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenTaiKhoan;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}