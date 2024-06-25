namespace LoginTest
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doanh Thu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(221, 40);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 22);
            this.dtpStartDate.TabIndex = 15;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(370, 40);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 22);
            this.dtpEndDate.TabIndex = 16;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Location = new System.Drawing.Point(521, 38);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(41, 30);
            this.btnOkCustomDate.TabIndex = 17;
            this.btnOkCustomDate.Text = "OK";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.Visible = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.Location = new System.Drawing.Point(568, 38);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(120, 30);
            this.btnCustomDate.TabIndex = 18;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(694, 38);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(120, 30);
            this.btnToday.TabIndex = 19;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(820, 38);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast7Days.TabIndex = 20;
            this.btnLast7Days.Text = "7 ngày trước";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(946, 39);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(120, 30);
            this.btnLast30Days.TabIndex = 21;
            this.btnLast30Days.Text = "30 ngày trước";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(1072, 40);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(120, 30);
            this.btnThisMonth.TabIndex = 22;
            this.btnThisMonth.Text = "Tháng này";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 53);
            this.panel1.TabIndex = 23;
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.AutoSize = true;
            this.lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.Location = new System.Drawing.Point(13, 16);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(63, 20);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng đơn đặt hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Location = new System.Drawing.Point(232, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 53);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(13, 16);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(63, 20);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "100000";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(13, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Tổng doanh thu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotalProfit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(634, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 53);
            this.panel3.TabIndex = 25;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(13, 16);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(63, 20);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng lợi nhuận";
            // 
            // chartGrossRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend1);
            this.chartGrossRevenue.Location = new System.Drawing.Point(41, 163);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series1);
            this.chartGrossRevenue.Size = new System.Drawing.Size(701, 337);
            this.chartGrossRevenue.TabIndex = 26;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Doanh Thu Gộp";
            title1.Text = "Doanh Thu Gộp";
            this.chartGrossRevenue.Titles.Add(title1);
            // 
            // chartTopProducts
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend2);
            this.chartTopProducts.Location = new System.Drawing.Point(748, 163);
            this.chartTopProducts.Name = "chartTopProducts";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopProducts.Series.Add(series2);
            this.chartTopProducts.Size = new System.Drawing.Size(440, 545);
            this.chartTopProducts.TabIndex = 27;
            this.chartTopProducts.Text = "chartTopProducts";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            title2.Text = "Top 5 sản phẩm";
            this.chartTopProducts.Titles.Add(title2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblNumProducts);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblNumSuppliers);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblNumCustomers);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(41, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 202);
            this.panel4.TabIndex = 28;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.Location = new System.Drawing.Point(13, 128);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(63, 20);
            this.lblNumProducts.TabIndex = 6;
            this.lblNumProducts.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng sản phẩm";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.AutoSize = true;
            this.lblNumSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSuppliers.Location = new System.Drawing.Point(13, 85);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(63, 20);
            this.lblNumSuppliers.TabIndex = 4;
            this.lblNumSuppliers.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng truy cập";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.Location = new System.Drawing.Point(12, 45);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(63, 20);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng nhân viên";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvUnderstock);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(232, 506);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(510, 202);
            this.panel5.TabIndex = 29;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnderstock.Location = new System.Drawing.Point(18, 27);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.RowTemplate.Height = 24;
            this.dgvUnderstock.Size = new System.Drawing.Size(482, 156);
            this.dgvUnderstock.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Sản phẩm còn hàng";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 714);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Name = "frmDoanhThu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label label11;
    }
}