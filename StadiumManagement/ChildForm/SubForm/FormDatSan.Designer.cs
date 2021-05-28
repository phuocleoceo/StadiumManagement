
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSan = new System.Windows.Forms.DataGridView();
            this.lblSan = new System.Windows.Forms.Label();
            this.picSan = new System.Windows.Forms.PictureBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBatDauThue = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThucThue = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnTrangThai = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(769, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(672, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 36);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(567, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 36);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(458, 127);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 36);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.picSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSan.Location = new System.Drawing.Point(132, 59);
            this.picSan.Name = "picSan";
            this.picSan.Size = new System.Drawing.Size(100, 100);
            this.picSan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSan.TabIndex = 64;
            this.picSan.TabStop = false;
            this.picSan.Click += new System.EventHandler(this.picSan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(893, 72);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(124, 26);
            this.txtTongTien.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Hoá đơn: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tổng tiền : ";
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
            this.label6.Location = new System.Drawing.Point(800, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Tiền cọc : ";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(893, 21);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(124, 26);
            this.txtTienCoc.TabIndex = 62;
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
            // txtHoaDon
            // 
            this.txtHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDon.Location = new System.Drawing.Point(132, 17);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.ReadOnly = true;
            this.txtHoaDon.Size = new System.Drawing.Size(173, 26);
            this.txtHoaDon.TabIndex = 70;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(869, 127);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(93, 36);
            this.btnXacNhan.TabIndex = 71;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangThai.Location = new System.Drawing.Point(132, 167);
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Size = new System.Drawing.Size(100, 32);
            this.btnTrangThai.TabIndex = 14;
            this.btnTrangThai.Text = "Trạng thái";
            this.btnTrangThai.UseVisualStyleBackColor = true;
            this.btnTrangThai.Click += new System.EventHandler(this.btnTrangThai_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(917, 179);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            this.txtSearch.TabIndex = 72;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(892, 178);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 73;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 566);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtHoaDon);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.dtpKetThucThue);
            this.Controls.Add(this.dtpBatDauThue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSan);
            this.Controls.Add(this.picSan);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTrangThai);
            this.Controls.Add(this.btnThem);
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

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSan;
        private System.Windows.Forms.Label lblSan;
        private System.Windows.Forms.PictureBox picSan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBatDauThue;
        private System.Windows.Forms.DateTimePicker dtpKetThucThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnTrangThai;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}