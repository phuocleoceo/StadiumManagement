
namespace GUILayer.ChildForm.SubForm
{
    partial class FormDatSan
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
            this.dgvSan = new System.Windows.Forms.DataGridView();
            this.lblSan = new System.Windows.Forms.Label();
            this.picSan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBatDauThue = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThucThue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.btnXacNhan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSua = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnTrangThai = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtHoaDon = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTienCoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSan
            // 
            this.dgvSan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSan.Location = new System.Drawing.Point(12, 206);
            this.dgvSan.Name = "dgvSan";
            this.dgvSan.Size = new System.Drawing.Size(1005, 348);
            this.dgvSan.TabIndex = 10;
            this.dgvSan.SelectionChanged += new System.EventHandler(this.dgvSan_SelectionChanged);
            // 
            // lblSan
            // 
            this.lblSan.AutoSize = true;
            this.lblSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSan.Location = new System.Drawing.Point(259, 96);
            this.lblSan.Name = "lblSan";
            this.lblSan.Size = new System.Drawing.Size(132, 20);
            this.lblSan.TabIndex = 65;
            this.lblSan.Text = "Click to choose ...";
            // 
            // picSan
            // 
            this.picSan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSan.Location = new System.Drawing.Point(132, 59);
            this.picSan.Name = "picSan";
            this.picSan.Size = new System.Drawing.Size(100, 100);
            this.picSan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSan.TabIndex = 64;
            this.picSan.TabStop = false;
            this.picSan.Click += new System.EventHandler(this.picSan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Sân : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Kết thúc thuê : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Bắt đầu thuê : ";
            // 
            // dtpBatDauThue
            // 
            this.dtpBatDauThue.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpBatDauThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDauThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDauThue.Location = new System.Drawing.Point(552, 19);
            this.dtpBatDauThue.Name = "dtpBatDauThue";
            this.dtpBatDauThue.Size = new System.Drawing.Size(200, 26);
            this.dtpBatDauThue.TabIndex = 68;
            // 
            // dtpKetThucThue
            // 
            this.dtpKetThucThue.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpKetThucThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThucThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThucThue.Location = new System.Drawing.Point(552, 70);
            this.dtpKetThucThue.Name = "dtpKetThucThue";
            this.dtpKetThucThue.Size = new System.Drawing.Size(200, 26);
            this.dtpKetThucThue.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tiền cọc : ";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(274, 137);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(0, 17);
            this.lblGia.TabIndex = 69;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.Control;
            this.btnXacNhan.Depth = 0;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(866, 125);
            this.btnXacNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Primary = true;
            this.btnXacNhan.Size = new System.Drawing.Size(93, 36);
            this.btnXacNhan.TabIndex = 83;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(769, 125);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(71, 36);
            this.btnClear.TabIndex = 84;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(662, 125);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(71, 36);
            this.btnXoa.TabIndex = 85;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Depth = 0;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(560, 125);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Primary = true;
            this.btnSua.Size = new System.Drawing.Size(71, 36);
            this.btnSua.TabIndex = 86;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(460, 125);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(71, 36);
            this.btnThem.TabIndex = 87;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(913, 177);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 82;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(880, 178);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 81;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.AutoSize = true;
            this.btnTrangThai.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrangThai.Depth = 0;
            this.btnTrangThai.Location = new System.Drawing.Point(133, 161);
            this.btnTrangThai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrangThai.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Primary = false;
            this.btnTrangThai.Size = new System.Drawing.Size(92, 36);
            this.btnTrangThai.TabIndex = 88;
            this.btnTrangThai.Text = "Trạng thái";
            this.btnTrangThai.UseVisualStyleBackColor = true;
            this.btnTrangThai.Click += new System.EventHandler(this.btnTrangThai_Click);
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.AutoSize = true;
            this.txtHoaDon.Depth = 0;
            this.txtHoaDon.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHoaDon.Location = new System.Drawing.Point(133, 21);
            this.txtHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(30, 19);
            this.txtHoaDon.TabIndex = 90;
            this.txtHoaDon.Text = "xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Hoá đơn: ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Depth = 0;
            this.txtTongTien.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTongTien.Location = new System.Drawing.Point(890, 72);
            this.txtTongTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(30, 19);
            this.txtTongTien.TabIndex = 92;
            this.txtTongTien.Text = "xxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tổng tiền : ";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Depth = 0;
            this.txtTienCoc.Hint = "";
            this.txtTienCoc.Location = new System.Drawing.Point(894, 25);
            this.txtTienCoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.PasswordChar = '\0';
            this.txtTienCoc.SelectedText = "";
            this.txtTienCoc.SelectionLength = 0;
            this.txtTienCoc.SelectionStart = 0;
            this.txtTienCoc.Size = new System.Drawing.Size(105, 23);
            this.txtTienCoc.TabIndex = 93;
            this.txtTienCoc.UseSystemPasswordChar = false;
            // 
            // FormDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrangThai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.dtpKetThucThue);
            this.Controls.Add(this.dtpBatDauThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSan);
            this.Controls.Add(this.picSan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSan);
            this.Name = "FormDatSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt sân";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSan;
        private System.Windows.Forms.Label lblSan;
        private System.Windows.Forms.PictureBox picSan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBatDauThue;
        private System.Windows.Forms.DateTimePicker dtpKetThucThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGia;
        private MaterialSkin.Controls.MaterialRaisedButton btnXacNhan;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnSua;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnTrangThai;
        private MaterialSkin.Controls.MaterialLabel txtHoaDon;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel txtTongTien;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTienCoc;
    }
}