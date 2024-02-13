namespace PetCareManagementSystem.GUI.Forms
{
    partial class DashboardForm
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
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundedPanel3 = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.roundedPanel2 = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelServicesCompleted = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DashboardTabPanel = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.lblDatCho = new System.Windows.Forms.Label();
            this.LblBaoCao = new System.Windows.Forms.Label();
            this.LblTongQuan = new System.Windows.Forms.Label();
            this.DashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelServicesCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DashboardTabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.DashboardPanel.Controls.Add(this.chart1);
            this.DashboardPanel.Controls.Add(this.roundedPanel3);
            this.DashboardPanel.Controls.Add(this.roundedPanel2);
            this.DashboardPanel.Controls.Add(this.roundedPanel1);
            this.DashboardPanel.Controls.Add(this.panelServicesCompleted);
            this.DashboardPanel.Controls.Add(this.DashboardTabPanel);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1336, 707);
            this.DashboardPanel.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Format = "MMM";
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            chartArea1.AxisX.LineWidth = 4;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Size = 4F;
            chartArea1.AxisX.MinorGrid.LineWidth = 4;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX2.LineWidth = 4;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LabelStyle.Format = "{0:0}đ";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Size = 2F;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 307);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            series1.YValuesPerPoint = 12;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1043, 370);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "GrossRevenueList";
            title1.Text = "Doanh thu hàng tháng";
            this.chart1.Titles.Add(title1);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.Controls.Add(this.label7);
            this.roundedPanel3.Controls.Add(this.label8);
            this.roundedPanel3.Controls.Add(this.pictureBox4);
            this.roundedPanel3.Location = new System.Drawing.Point(826, 112);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Radius = 20;
            this.roundedPanel3.Size = new System.Drawing.Size(240, 175);
            this.roundedPanel3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "32,099,969đ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label8.Location = new System.Drawing.Point(11, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lợi nhuận từ dịch vụ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PetCareManagementSystem.GUI.Properties.Resources.pie_chart;
            this.pictureBox4.Location = new System.Drawing.Point(11, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.label6);
            this.roundedPanel2.Controls.Add(this.pictureBox3);
            this.roundedPanel2.Location = new System.Drawing.Point(561, 112);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(240, 175);
            this.roundedPanel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "32,100,160đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(11, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doanh thu từ dịch vụ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PetCareManagementSystem.GUI.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(11, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.pictureBox2);
            this.roundedPanel1.Location = new System.Drawing.Point(289, 112);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(240, 175);
            this.roundedPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "22";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dịch vụ chưa hoàn thành";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PetCareManagementSystem.GUI.Properties.Resources.remove;
            this.pictureBox2.Location = new System.Drawing.Point(11, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panelServicesCompleted
            // 
            this.panelServicesCompleted.BackColor = System.Drawing.Color.White;
            this.panelServicesCompleted.Controls.Add(this.label2);
            this.panelServicesCompleted.Controls.Add(this.label1);
            this.panelServicesCompleted.Controls.Add(this.pictureBox1);
            this.panelServicesCompleted.Location = new System.Drawing.Point(12, 112);
            this.panelServicesCompleted.Name = "panelServicesCompleted";
            this.panelServicesCompleted.Radius = 20;
            this.panelServicesCompleted.Size = new System.Drawing.Size(240, 175);
            this.panelServicesCompleted.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(11, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dịch vụ đã hoàn thành";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetCareManagementSystem.GUI.Properties.Resources.check_mark;
            this.pictureBox1.Location = new System.Drawing.Point(11, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardTabPanel
            // 
            this.DashboardTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardTabPanel.BackColor = System.Drawing.Color.White;
            this.DashboardTabPanel.Controls.Add(this.lblDatCho);
            this.DashboardTabPanel.Controls.Add(this.LblBaoCao);
            this.DashboardTabPanel.Controls.Add(this.LblTongQuan);
            this.DashboardTabPanel.Location = new System.Drawing.Point(12, 25);
            this.DashboardTabPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardTabPanel.Name = "DashboardTabPanel";
            this.DashboardTabPanel.Radius = 5;
            this.DashboardTabPanel.Size = new System.Drawing.Size(1312, 63);
            this.DashboardTabPanel.TabIndex = 1;
            // 
            // lblDatCho
            // 
            this.lblDatCho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDatCho.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDatCho.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatCho.Location = new System.Drawing.Point(232, 0);
            this.lblDatCho.Name = "lblDatCho";
            this.lblDatCho.Size = new System.Drawing.Size(113, 63);
            this.lblDatCho.TabIndex = 2;
            this.lblDatCho.Text = "Đặt chỗ";
            this.lblDatCho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBaoCao
            // 
            this.LblBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBaoCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblBaoCao.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaoCao.Location = new System.Drawing.Point(124, 0);
            this.LblBaoCao.Name = "LblBaoCao";
            this.LblBaoCao.Size = new System.Drawing.Size(108, 63);
            this.LblBaoCao.TabIndex = 1;
            this.LblBaoCao.Text = "Báo cáo";
            this.LblBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTongQuan
            // 
            this.LblTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTongQuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTongQuan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTongQuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.LblTongQuan.Location = new System.Drawing.Point(0, 0);
            this.LblTongQuan.Name = "LblTongQuan";
            this.LblTongQuan.Size = new System.Drawing.Size(124, 63);
            this.LblTongQuan.TabIndex = 0;
            this.LblTongQuan.Text = "Tổng quan";
            this.LblTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 707);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.DashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelServicesCompleted.ResumeLayout(false);
            this.panelServicesCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DashboardTabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private CustomControls.RoundedPanel DashboardTabPanel;
        private System.Windows.Forms.Label LblTongQuan;
        private System.Windows.Forms.Label lblDatCho;
        private System.Windows.Forms.Label LblBaoCao;
        private CustomControls.RoundedPanel panelServicesCompleted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}