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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inforSpa = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.AddNewSpaBooking = new Guna.UI2.WinForms.Guna2Button();
            this.dgSpaBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetInformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeciesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerSpa = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.inforSpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSpaBooking)).BeginInit();
            this.headerSpa.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.Filter = "";
            this.bindingSource1.Sort = "";
            // 
            // inforSpa
            // 
            this.inforSpa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inforSpa.BackColor = System.Drawing.Color.White;
            this.inforSpa.Controls.Add(this.AddNewSpaBooking);
            this.inforSpa.Controls.Add(this.dgSpaBooking);
            this.inforSpa.Location = new System.Drawing.Point(21, 82);
            this.inforSpa.Name = "inforSpa";
            this.inforSpa.Radius = 10;
            this.inforSpa.Size = new System.Drawing.Size(1128, 531);
            this.inforSpa.TabIndex = 4;
            // 
            // AddNewSpaBooking
            // 
            this.AddNewSpaBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewSpaBooking.BorderRadius = 4;
            this.AddNewSpaBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddNewSpaBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddNewSpaBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddNewSpaBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddNewSpaBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.AddNewSpaBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewSpaBooking.ForeColor = System.Drawing.Color.White;
            this.AddNewSpaBooking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.AddNewSpaBooking.Location = new System.Drawing.Point(1029, 13);
            this.AddNewSpaBooking.Name = "AddNewSpaBooking";
            this.AddNewSpaBooking.Size = new System.Drawing.Size(85, 38);
            this.AddNewSpaBooking.TabIndex = 1;
            this.AddNewSpaBooking.Text = "Mới";
            this.AddNewSpaBooking.Click += new System.EventHandler(this.AddNewSpaBooking_Click);
            // 
            // dgSpaBooking
            // 
            this.dgSpaBooking.AllowUserToAddRows = false;
            this.dgSpaBooking.AllowUserToOrderColumns = true;
            this.dgSpaBooking.AllowUserToResizeColumns = false;
            this.dgSpaBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgSpaBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgSpaBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSpaBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSpaBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgSpaBooking.ColumnHeadersHeight = 50;
            this.dgSpaBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgSpaBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Date,
            this.ServiceName,
            this.TotalPrice,
            this.EmployeeName,
            this.PetName,
            this.PetInformation,
            this.BreedName,
            this.SpeciesName,
            this.TypeName,
            this.RoomID,
            this.EmployeeID,
            this.Status,
            this.PaymentStatus,
            this.deleteItem});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSpaBooking.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgSpaBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.Location = new System.Drawing.Point(1, 67);
            this.dgSpaBooking.Name = "dgSpaBooking";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSpaBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgSpaBooking.RowHeadersVisible = false;
            this.dgSpaBooking.RowHeadersWidth = 40;
            this.dgSpaBooking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSpaBooking.RowTemplate.Height = 50;
            this.dgSpaBooking.Size = new System.Drawing.Size(1128, 464);
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
            this.dgSpaBooking.ThemeStyle.RowsStyle.Height = 50;
            this.dgSpaBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgSpaBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgSpaBooking.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSpaBooking_CellValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "BookingID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID.Width = 103;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Tên Khách Hàng";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày & Giờ";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Dịch vụ";
            this.ServiceName.MinimumWidth = 6;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 102;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Giá";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 103;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Người tắm rửa";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 150;
            // 
            // PetName
            // 
            this.PetName.DataPropertyName = "PetName";
            this.PetName.HeaderText = "Tên thú cưng";
            this.PetName.MinimumWidth = 6;
            this.PetName.Name = "PetName";
            this.PetName.ReadOnly = true;
            this.PetName.Width = 150;
            // 
            // PetInformation
            // 
            this.PetInformation.DataPropertyName = "PetInformation";
            this.PetInformation.HeaderText = "Thông tin thú cưng";
            this.PetInformation.MinimumWidth = 6;
            this.PetInformation.Name = "PetInformation";
            this.PetInformation.ReadOnly = true;
            this.PetInformation.Width = 180;
            // 
            // BreedName
            // 
            this.BreedName.DataPropertyName = "BreedName";
            this.BreedName.HeaderText = "Tên giống";
            this.BreedName.MinimumWidth = 6;
            this.BreedName.Name = "BreedName";
            this.BreedName.Visible = false;
            this.BreedName.Width = 125;
            // 
            // SpeciesName
            // 
            this.SpeciesName.DataPropertyName = "SpeciesName";
            this.SpeciesName.HeaderText = "Tên loài";
            this.SpeciesName.MinimumWidth = 6;
            this.SpeciesName.Name = "SpeciesName";
            this.SpeciesName.Visible = false;
            this.SpeciesName.Width = 125;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Tên dịch vụ";
            this.TypeName.MinimumWidth = 6;
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = false;
            this.TypeName.Width = 125;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "ID Phòng";
            this.RoomID.MinimumWidth = 6;
            this.RoomID.Name = "RoomID";
            this.RoomID.Visible = false;
            this.RoomID.Width = 125;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "ID Nhân viên";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = false;
            this.EmployeeID.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.4F);
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(4, 11, 4, 11);
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.DefaultCellStyle = dataGridViewCellStyle10;
            this.Status.DropDownWidth = 2;
            this.Status.FillWeight = 130F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled",
            "In Progress",
            "Completed",
            "Rejected"});
            this.Status.MaxDropDownItems = 16;
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 130;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(4, 11, 4, 11);
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentStatus.DefaultCellStyle = dataGridViewCellStyle11;
            this.PaymentStatus.DropDownWidth = 2;
            this.PaymentStatus.HeaderText = "Trạng thái thanh toán";
            this.PaymentStatus.Items.AddRange(new object[] {
            "Pending",
            "Paid"});
            this.PaymentStatus.MaxDropDownItems = 16;
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PaymentStatus.Width = 150;
            // 
            // deleteItem
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.deleteItem.DefaultCellStyle = dataGridViewCellStyle12;
            this.deleteItem.HeaderText = "Hành động";
            this.deleteItem.MinimumWidth = 6;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteItem.Text = "🗑️";
            this.deleteItem.ToolTipText = "🗑️";
            this.deleteItem.UseColumnTextForButtonValue = true;
            this.deleteItem.Width = 125;
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
            // SpaBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 625);
            this.Controls.Add(this.inforSpa);
            this.Controls.Add(this.headerSpa);
            this.Name = "SpaBookingForm";
            this.Text = "SpaBookingForm";
            this.Load += new System.EventHandler(this.SpaBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button AddNewSpaBooking;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewLinkColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeciesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewButtonColumn deleteItem;
    }
}