namespace PetCareManagementSystem.GUI.Forms
{
    partial class ChartReceiptForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.btn7days = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelServicesCompleted = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btn1month = new System.Windows.Forms.Button();
            this.TypeCatechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumberReceiptchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundedPanel1 = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DashboardPanel.SuspendLayout();
            this.panelServicesCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeCatechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberReceiptchart)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.DashboardPanel.Controls.Add(this.btn7days);
            this.DashboardPanel.Controls.Add(this.button1);
            this.DashboardPanel.Controls.Add(this.panelServicesCompleted);
            this.DashboardPanel.Controls.Add(this.dtpEndDate);
            this.DashboardPanel.Controls.Add(this.dtpStartDate);
            this.DashboardPanel.Controls.Add(this.btn1month);
            this.DashboardPanel.Controls.Add(this.TypeCatechart);
            this.DashboardPanel.Controls.Add(this.NumberReceiptchart);
            this.DashboardPanel.Controls.Add(this.roundedPanel1);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1414, 635);
            this.DashboardPanel.TabIndex = 2;
            // 
            // btn7days
            // 
            this.btn7days.Location = new System.Drawing.Point(1123, 502);
            this.btn7days.Name = "btn7days";
            this.btn7days.Size = new System.Drawing.Size(75, 23);
            this.btn7days.TabIndex = 14;
            this.btn7days.Text = "7 days";
            this.btn7days.UseVisualStyleBackColor = true;
            this.btn7days.Click += new System.EventHandler(this.btn7days_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelServicesCompleted
            // 
            this.panelServicesCompleted.BackColor = System.Drawing.Color.White;
            this.panelServicesCompleted.Controls.Add(this.pictureBox4);
            this.panelServicesCompleted.Controls.Add(this.label2);
            this.panelServicesCompleted.Controls.Add(this.label1);
            this.panelServicesCompleted.Location = new System.Drawing.Point(269, 110);
            this.panelServicesCompleted.Name = "panelServicesCompleted";
            this.panelServicesCompleted.Radius = 20;
            this.panelServicesCompleted.Size = new System.Drawing.Size(166, 129);
            this.panelServicesCompleted.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "102";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng số sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(991, 401);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 25);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(991, 361);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 25);
            this.dtpStartDate.TabIndex = 11;
            // 
            // btn1month
            // 
            this.btn1month.Location = new System.Drawing.Point(991, 447);
            this.btn1month.Name = "btn1month";
            this.btn1month.Size = new System.Drawing.Size(106, 35);
            this.btn1month.TabIndex = 10;
            this.btn1month.Text = "This Month";
            this.btn1month.UseVisualStyleBackColor = true;
            this.btn1month.Click += new System.EventHandler(this.btn1month_Click);
            // 
            // TypeCatechart
            // 
            chartArea19.Name = "ChartArea1";
            this.TypeCatechart.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.TypeCatechart.Legends.Add(legend19);
            this.TypeCatechart.Location = new System.Drawing.Point(898, 45);
            this.TypeCatechart.Name = "TypeCatechart";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.TypeCatechart.Series.Add(series19);
            this.TypeCatechart.Size = new System.Drawing.Size(300, 300);
            this.TypeCatechart.TabIndex = 9;
            this.TypeCatechart.Text = "chart1";
            title10.Name = "Title1";
            title10.Text = "Tổng sản phẩm theo Cate";
            this.TypeCatechart.Titles.Add(title10);
            // 
            // NumberReceiptchart
            // 
            chartArea20.Name = "ChartArea1";
            this.NumberReceiptchart.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.NumberReceiptchart.Legends.Add(legend20);
            this.NumberReceiptchart.Location = new System.Drawing.Point(36, 259);
            this.NumberReceiptchart.Name = "NumberReceiptchart";
            series20.ChartArea = "ChartArea1";
            series20.CustomProperties = "PointWidth=0.5";
            series20.Legend = "Legend1";
            series20.Name = "Series2";
            this.NumberReceiptchart.Series.Add(series20);
            this.NumberReceiptchart.Size = new System.Drawing.Size(817, 373);
            this.NumberReceiptchart.TabIndex = 8;
            this.NumberReceiptchart.Text = "chartReceipt";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.pictureBox3);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Location = new System.Drawing.Point(53, 110);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(157, 130);
            this.roundedPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 91);
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
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng chi phí nhập kho";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PetCareManagementSystem.GUI.Properties.Resources.dollar;
            this.pictureBox3.Location = new System.Drawing.Point(12, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PetCareManagementSystem.GUI.Properties.Resources.pie_chart;
            this.pictureBox4.Location = new System.Drawing.Point(18, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // ChartReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 635);
            this.Controls.Add(this.DashboardPanel);
            this.Name = "ChartReceiptForm";
            this.Text = "ChartReceiptForm";
            this.Load += new System.EventHandler(this.ChartReceiptForm_Load);
            this.DashboardPanel.ResumeLayout(false);
            this.panelServicesCompleted.ResumeLayout(false);
            this.panelServicesCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeCatechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberReceiptchart)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Button btn7days;
        private System.Windows.Forms.Button button1;
        private CustomControls.RoundedPanel panelServicesCompleted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btn1month;
        private System.Windows.Forms.DataVisualization.Charting.Chart TypeCatechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart NumberReceiptchart;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}