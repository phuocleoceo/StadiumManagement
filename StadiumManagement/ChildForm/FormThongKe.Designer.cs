
namespace GUILayer.ChildForm
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TCThongKe = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTongDoanhTHu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconDBMoney = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconDBProduct = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKhachHangHomNay = new System.Windows.Forms.Label();
            this.lblKhachHangThang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconDBHoaDon = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoaDonHomNay = new System.Windows.Forms.Label();
            this.lblHoaDonThang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSan = new System.Windows.Forms.Button();
            this.btnDV = new System.Windows.Forms.Button();
            this.TCThongKe.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSan)).BeginInit();
            this.SuspendLayout();
            // 
            // TCThongKe
            // 
            this.TCThongKe.Controls.Add(this.tabPage2);
            this.TCThongKe.Controls.Add(this.tabPage1);
            this.TCThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCThongKe.Location = new System.Drawing.Point(0, 0);
            this.TCThongKe.Name = "TCThongKe";
            this.TCThongKe.SelectedIndex = 0;
            this.TCThongKe.Size = new System.Drawing.Size(1041, 602);
            this.TCThongKe.TabIndex = 0;
            this.TCThongKe.Selected += new System.Windows.Forms.TabControlEventHandler(this.TCThongKe_Selected);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTongDoanhTHu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnLoc);
            this.tabPage2.Controls.Add(this.dtpToDate);
            this.tabPage2.Controls.Add(this.dtpFromDate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvBill);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử hoá đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTongDoanhTHu
            // 
            this.lblTongDoanhTHu.AutoSize = true;
            this.lblTongDoanhTHu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhTHu.Location = new System.Drawing.Point(540, 525);
            this.lblTongDoanhTHu.Name = "lblTongDoanhTHu";
            this.lblTongDoanhTHu.Size = new System.Drawing.Size(91, 31);
            this.lblTongDoanhTHu.TabIndex = 15;
            this.lblTongDoanhTHu.Text = "*******";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tổng doanh thu :";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(483, 15);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(101, 41);
            this.btnLoc.TabIndex = 14;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(680, 22);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(310, 29);
            this.dtpToDate.TabIndex = 13;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(122, 22);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(310, 29);
            this.dtpFromDate.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ : ";
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(26, 68);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(986, 438);
            this.dgvBill.TabIndex = 11;
            this.dgvBill.DoubleClick += new System.EventHandler(this.dgvBill_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDV);
            this.tabPage1.Controls.Add(this.btnSan);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chartDV);
            this.tabPage1.Controls.Add(this.chartSan);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 573);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống kê số liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.iconDBMoney);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblDoanhThuHomNay);
            this.panel3.Controls.Add(this.lblDoanhThuThang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(697, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 136);
            this.panel3.TabIndex = 8;
            // 
            // iconDBMoney
            // 
            this.iconDBMoney.BackColor = System.Drawing.Color.Crimson;
            this.iconDBMoney.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconDBMoney.IconColor = System.Drawing.Color.White;
            this.iconDBMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBMoney.IconSize = 111;
            this.iconDBMoney.Location = new System.Drawing.Point(183, -11);
            this.iconDBMoney.Name = "iconDBMoney";
            this.iconDBMoney.Size = new System.Drawing.Size(123, 111);
            this.iconDBMoney.TabIndex = 3;
            this.iconDBMoney.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hôm nay : ";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(96, 91);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(45, 20);
            this.lblDoanhThuHomNay.TabIndex = 2;
            this.lblDoanhThuHomNay.Text = "9999";
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(11, 44);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(159, 33);
            this.lblDoanhThuThang.TabIndex = 1;
            this.lblDoanhThuThang.Text = "10.000.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doanh thu (tháng)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.iconDBProduct);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblKhachHangHomNay);
            this.panel2.Controls.Add(this.lblKhachHangThang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(375, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 136);
            this.panel2.TabIndex = 7;
            // 
            // iconDBProduct
            // 
            this.iconDBProduct.BackColor = System.Drawing.Color.DarkMagenta;
            this.iconDBProduct.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconDBProduct.IconColor = System.Drawing.Color.White;
            this.iconDBProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBProduct.IconSize = 111;
            this.iconDBProduct.Location = new System.Drawing.Point(185, 1);
            this.iconDBProduct.Name = "iconDBProduct";
            this.iconDBProduct.Size = new System.Drawing.Size(123, 111);
            this.iconDBProduct.TabIndex = 3;
            this.iconDBProduct.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hôm nay : ";
            // 
            // lblKhachHangHomNay
            // 
            this.lblKhachHangHomNay.AutoSize = true;
            this.lblKhachHangHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangHomNay.ForeColor = System.Drawing.Color.White;
            this.lblKhachHangHomNay.Location = new System.Drawing.Point(96, 92);
            this.lblKhachHangHomNay.Name = "lblKhachHangHomNay";
            this.lblKhachHangHomNay.Size = new System.Drawing.Size(45, 20);
            this.lblKhachHangHomNay.TabIndex = 2;
            this.lblKhachHangHomNay.Text = "9999";
            // 
            // lblKhachHangThang
            // 
            this.lblKhachHangThang.AutoSize = true;
            this.lblKhachHangThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangThang.ForeColor = System.Drawing.Color.White;
            this.lblKhachHangThang.Location = new System.Drawing.Point(11, 44);
            this.lblKhachHangThang.Name = "lblKhachHangThang";
            this.lblKhachHangThang.Size = new System.Drawing.Size(159, 33);
            this.lblKhachHangThang.TabIndex = 1;
            this.lblKhachHangThang.Text = "10.000.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng (tháng)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.iconDBHoaDon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblHoaDonHomNay);
            this.panel1.Controls.Add(this.lblHoaDonThang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(52, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 136);
            this.panel1.TabIndex = 6;
            // 
            // iconDBHoaDon
            // 
            this.iconDBHoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconDBHoaDon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconDBHoaDon.IconColor = System.Drawing.Color.White;
            this.iconDBHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBHoaDon.IconSize = 111;
            this.iconDBHoaDon.Location = new System.Drawing.Point(194, 4);
            this.iconDBHoaDon.Name = "iconDBHoaDon";
            this.iconDBHoaDon.Size = new System.Drawing.Size(123, 111);
            this.iconDBHoaDon.TabIndex = 3;
            this.iconDBHoaDon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hôm nay : ";
            // 
            // lblHoaDonHomNay
            // 
            this.lblHoaDonHomNay.AutoSize = true;
            this.lblHoaDonHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonHomNay.ForeColor = System.Drawing.Color.White;
            this.lblHoaDonHomNay.Location = new System.Drawing.Point(96, 92);
            this.lblHoaDonHomNay.Name = "lblHoaDonHomNay";
            this.lblHoaDonHomNay.Size = new System.Drawing.Size(45, 20);
            this.lblHoaDonHomNay.TabIndex = 2;
            this.lblHoaDonHomNay.Text = "9999";
            // 
            // lblHoaDonThang
            // 
            this.lblHoaDonThang.AutoSize = true;
            this.lblHoaDonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonThang.ForeColor = System.Drawing.Color.White;
            this.lblHoaDonThang.Location = new System.Drawing.Point(14, 44);
            this.lblHoaDonThang.Name = "lblHoaDonThang";
            this.lblHoaDonThang.Size = new System.Drawing.Size(159, 33);
            this.lblHoaDonThang.TabIndex = 1;
            this.lblHoaDonThang.Text = "10.000.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hóa đơn (tháng)";
            // 
            // chartDV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDV.Legends.Add(legend1);
            this.chartDV.Location = new System.Drawing.Point(589, 182);
            this.chartDV.Name = "chartDV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDV.Series.Add(series1);
            this.chartDV.Size = new System.Drawing.Size(383, 383);
            this.chartDV.TabIndex = 0;
            this.chartDV.Text = "Sân được thuê";
            // 
            // chartSan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSan.Legends.Add(legend2);
            this.chartSan.Location = new System.Drawing.Point(52, 182);
            this.chartSan.Name = "chartSan";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSan.Series.Add(series2);
            this.chartSan.Size = new System.Drawing.Size(383, 383);
            this.chartSan.TabIndex = 0;
            this.chartSan.Text = "Sân được thuê";
            // 
            // btnSan
            // 
            this.btnSan.Location = new System.Drawing.Point(509, 297);
            this.btnSan.Name = "btnSan";
            this.btnSan.Size = new System.Drawing.Size(63, 34);
            this.btnSan.TabIndex = 9;
            this.btnSan.Text = "Sân";
            this.btnSan.UseVisualStyleBackColor = true;
            // 
            // btnDV
            // 
            this.btnDV.Location = new System.Drawing.Point(509, 349);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(63, 34);
            this.btnDV.TabIndex = 9;
            this.btnDV.Text = "Dịch vụ";
            this.btnDV.UseVisualStyleBackColor = true;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 602);
            this.Controls.Add(this.TCThongKe);
            this.Name = "FormThongKe";
            this.Text = "Thống kê";
            this.TCThongKe.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCThongKe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblTongDoanhTHu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSan;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconDBMoney;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconDBProduct;
        private System.Windows.Forms.Label lblKhachHangThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconDBHoaDon;
        private System.Windows.Forms.Label lblHoaDonHomNay;
        private System.Windows.Forms.Label lblHoaDonThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblKhachHangHomNay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Button btnSan;
    }
}