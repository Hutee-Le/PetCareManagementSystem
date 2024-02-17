namespace PetCareManagementSystem.GUI.Forms
{
    partial class SpaBookingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inforSpa = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.dgSpaBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.headerSpa = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAppointmentDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetInfor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inforSpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpaBooking)).BeginInit();
            this.headerSpa.SuspendLayout();
            this.SuspendLayout();
            // 
            // inforSpa
            // 
            this.inforSpa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inforSpa.BackColor = System.Drawing.Color.White;
            this.inforSpa.Controls.Add(this.dgSpaBooking);
            this.inforSpa.Location = new System.Drawing.Point(21, 82);
            this.inforSpa.Name = "inforSpa";
            this.inforSpa.Radius = 10;
            this.inforSpa.Size = new System.Drawing.Size(1128, 531);
            this.inforSpa.TabIndex = 4;
            // 
            // dgSpaBooking
            // 
            this.dgSpaBooking.AllowUserToAddRows = false;
            this.dgSpaBooking.AllowUserToResizeColumns = false;
            this.dgSpaBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgSpaBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSpaBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSpaBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSpaBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgSpaBooking.ColumnHeadersHeight = 50;
            this.dgSpaBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSpaBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colCustomerName,
            this.colAppointmentDateTime,
            this.Service,
            this.Price,
            this.Employee,
            this.PetName,
            this.PetInfor,
            this.UpdateTime,
            this.Status,
            this.PaymentStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSpaBooking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgSpaBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.Location = new System.Drawing.Point(1, 57);
            this.dgSpaBooking.Name = "dgSpaBooking";
            this.dgSpaBooking.RowHeadersVisible = false;
            this.dgSpaBooking.RowHeadersWidth = 51;
            this.dgSpaBooking.RowTemplate.Height = 24;
            this.dgSpaBooking.Size = new System.Drawing.Size(1128, 474);
            this.dgSpaBooking.TabIndex = 0;
            this.dgSpaBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgSpaBooking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgSpaBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgSpaBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgSpaBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgSpaBooking.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgSpaBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSpaBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSpaBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgSpaBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSpaBooking.ThemeStyle.HeaderStyle.Height = 50;
            this.dgSpaBooking.ThemeStyle.ReadOnly = false;
            this.dgSpaBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgSpaBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgSpaBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgSpaBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgSpaBooking.ThemeStyle.RowsStyle.Height = 24;
            this.dgSpaBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // headerSpa
            // 
            this.headerSpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.headerSpa.Controls.Add(this.label1);
            this.headerSpa.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSpa.Location = new System.Drawing.Point(0, 0);
            this.headerSpa.Name = "headerSpa";
            this.headerSpa.Radius = 5;
            this.headerSpa.Size = new System.Drawing.Size(1171, 100);
            this.headerSpa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(1147, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn Đặt Spa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 103;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Tên Khách Hàng";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 150;
            // 
            // colAppointmentDateTime
            // 
            this.colAppointmentDateTime.HeaderText = "Ngày & Giờ";
            this.colAppointmentDateTime.MinimumWidth = 6;
            this.colAppointmentDateTime.Name = "colAppointmentDateTime";
            this.colAppointmentDateTime.Width = 150;
            // 
            // Service
            // 
            this.Service.HeaderText = "Dịch vụ";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.Width = 102;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 103;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Người tắm rửa";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.Width = 150;
            // 
            // PetName
            // 
            this.PetName.HeaderText = "Tên thú cưng";
            this.PetName.MinimumWidth = 6;
            this.PetName.Name = "PetName";
            this.PetName.Width = 150;
            // 
            // PetInfor
            // 
            this.PetInfor.HeaderText = "Thông tin thú cưng";
            this.PetInfor.MinimumWidth = 6;
            this.PetInfor.Name = "PetInfor";
            this.PetInfor.Width = 180;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "Đã cập nhật lúc";
            this.UpdateTime.MinimumWidth = 6;
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 102;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.HeaderText = "Trạng thái thanh toán";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.Width = 150;
            // 
            // SpaBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 625);
            this.Controls.Add(this.inforSpa);
            this.Controls.Add(this.headerSpa);
            this.Name = "SpaBookingForm";
            this.Text = "SpaBookingForm";
            this.inforSpa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSpaBooking)).EndInit();
            this.headerSpa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private  CustomControls.RoundedPanel headerSpa;
        private  CustomControls.RoundedPanel inforSpa;
        private Guna.UI2.WinForms.Guna2DataGridView dgSpaBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppointmentDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn PaymentStatus;
    }
}