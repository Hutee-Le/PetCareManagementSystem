namespace PetCareManagementSystem.GUI.Forms
{
    partial class ManageSpaEmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerSpaEmployee = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.roundedPanel1 = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.dataGridViewSpaEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddNewSpaBooking = new Guna.UI2.WinForms.Guna2Button();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.EmployeeID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ImageUrl = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerSpaEmployee.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // headerSpaEmployee
            // 
            this.headerSpaEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.headerSpaEmployee.Controls.Add(this.lblTitleHeader);
            this.headerSpaEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerSpaEmployee.Location = new System.Drawing.Point(0, 0);
            this.headerSpaEmployee.Name = "headerSpaEmployee";
            this.headerSpaEmployee.Radius = 5;
            this.headerSpaEmployee.Size = new System.Drawing.Size(1171, 100);
            this.headerSpaEmployee.TabIndex = 4;
            // 
            // lblTitleHeader
            // 
            this.lblTitleHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleHeader.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeader.ForeColor = System.Drawing.Color.White;
            this.lblTitleHeader.Location = new System.Drawing.Point(12, 29);
            this.lblTitleHeader.Name = "lblTitleHeader";
            this.lblTitleHeader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitleHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleHeader.Size = new System.Drawing.Size(1147, 38);
            this.lblTitleHeader.TabIndex = 1;
            this.lblTitleHeader.Text = "Nhân viên Spa";
            this.lblTitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.dataGridViewSpaEmployees);
            this.roundedPanel1.Controls.Add(this.AddNewSpaBooking);
            this.roundedPanel1.Location = new System.Drawing.Point(21, 76);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 20;
            this.roundedPanel1.Size = new System.Drawing.Size(1128, 531);
            this.roundedPanel1.TabIndex = 5;
            // 
            // dataGridViewSpaEmployees
            // 
            this.dataGridViewSpaEmployees.AllowUserToAddRows = false;
            this.dataGridViewSpaEmployees.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewSpaEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSpaEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSpaEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSpaEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSpaEmployees.ColumnHeadersHeight = 50;
            this.dataGridViewSpaEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.ImageUrl,
            this.Name,
            this.Email,
            this.PhoneNumber,
            this.RoleName,
            this.Address,
            this.Status,
            this.Update,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpaEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSpaEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSpaEmployees.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewSpaEmployees.Name = "dataGridViewSpaEmployees";
            this.dataGridViewSpaEmployees.RowHeadersVisible = false;
            this.dataGridViewSpaEmployees.RowHeadersWidth = 40;
            this.dataGridViewSpaEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSpaEmployees.RowTemplate.Height = 50;
            this.dataGridViewSpaEmployees.Size = new System.Drawing.Size(1128, 454);
            this.dataGridViewSpaEmployees.TabIndex = 3;
            this.dataGridViewSpaEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSpaEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewSpaEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSpaEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewSpaEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewSpaEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSpaEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSpaEmployees.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridViewSpaEmployees.ThemeStyle.ReadOnly = false;
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewSpaEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.AddNewSpaBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.AddNewSpaBooking.ForeColor = System.Drawing.Color.White;
            this.AddNewSpaBooking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(74)))), ((int)(((byte)(190)))));
            this.AddNewSpaBooking.Location = new System.Drawing.Point(1030, 18);
            this.AddNewSpaBooking.Name = "AddNewSpaBooking";
            this.AddNewSpaBooking.Size = new System.Drawing.Size(85, 38);
            this.AddNewSpaBooking.TabIndex = 2;
            this.AddNewSpaBooking.Text = "Mới";
            // 
            // myImageList
            // 
            this.myImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.myImageList.ImageSize = new System.Drawing.Size(24, 24);
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeID.Width = 161;
            // 
            // ImageUrl
            // 
            this.ImageUrl.HeaderText = "Hình ảnh";
            this.ImageUrl.Image = global::PetCareManagementSystem.GUI.Properties.Resources.default_avatar;
            this.ImageUrl.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageUrl.MinimumWidth = 6;
            this.ImageUrl.Name = "ImageUrl";
            this.ImageUrl.Width = 161;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 161;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 162;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Số Điện Thoại Liên Hệ";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 190;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "Vai Trò";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 161;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 161;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Hành động";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // ManageSpaEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 625);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.headerSpaEmployee);
            this.Text = "ManageSpaEmployeesForm";
            this.Load += new System.EventHandler(this.ManageSpaEmployeesForm_Load);
            this.headerSpaEmployee.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel headerSpaEmployee;
        private System.Windows.Forms.Label lblTitleHeader;
        private CustomControls.RoundedPanel roundedPanel1;
        private Guna.UI2.WinForms.Guna2Button AddNewSpaBooking;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSpaEmployees;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.DataGridViewLinkColumn EmployeeID;
        private System.Windows.Forms.DataGridViewImageColumn ImageUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}