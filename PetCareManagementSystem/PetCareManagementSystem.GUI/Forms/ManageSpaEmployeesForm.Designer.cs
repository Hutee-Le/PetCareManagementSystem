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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.pnListSpaEmployee = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.dataGridViewSpaEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddNewSpaBooking = new Guna.UI2.WinForms.Guna2Button();
            this.headerSpaEmployee = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ImageURL = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChangePassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnListSpaEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaEmployees)).BeginInit();
            this.headerSpaEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // myImageList
            // 
            this.myImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.myImageList.ImageSize = new System.Drawing.Size(24, 24);
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnListSpaEmployee
            // 
            this.pnListSpaEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnListSpaEmployee.BackColor = System.Drawing.Color.White;
            this.pnListSpaEmployee.Controls.Add(this.dataGridViewSpaEmployees);
            this.pnListSpaEmployee.Controls.Add(this.AddNewSpaBooking);
            this.pnListSpaEmployee.Location = new System.Drawing.Point(21, 76);
            this.pnListSpaEmployee.Name = "pnListSpaEmployee";
            this.pnListSpaEmployee.Radius = 20;
            this.pnListSpaEmployee.Size = new System.Drawing.Size(1128, 531);
            this.pnListSpaEmployee.TabIndex = 5;
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
            this.ImageURL,
            this.Name,
            this.Email,
            this.PhoneNumber,
            this.RoleName,
            this.Address,
            this.Status,
            this.ChangePassword,
            this.Update,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSpaEmployees.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.dataGridViewSpaEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpaEmployees_CellContentClick);
            this.dataGridViewSpaEmployees.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSpaEmployees_CellMouseMove);
            this.dataGridViewSpaEmployees.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewSpaEmployees_CellPainting);
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
            this.AddNewSpaBooking.Click += new System.EventHandler(this.AddNewSpaBooking_Click);
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
            this.lblTitleHeader.Text = "Danh sách nhân viên";
            this.lblTitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // ImageURL
            // 
            this.ImageURL.DataPropertyName = "Image";
            this.ImageURL.HeaderText = "Hình ảnh";
            this.ImageURL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageURL.MinimumWidth = 6;
            this.ImageURL.Name = "ImageURL";
            this.ImageURL.Width = 161;
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
            this.Status.FalseValue = "Busy";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.TrueValue = "Available";
            this.Status.Width = 125;
            // 
            // ChangePassword
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.ChangePassword.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChangePassword.HeaderText = "Hành động";
            this.ChangePassword.MinimumWidth = 4;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Text = "🔒";
            this.ChangePassword.ToolTipText = "🔒";
            this.ChangePassword.UseColumnTextForButtonValue = true;
            this.ChangePassword.Width = 125;
            // 
            // Update
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Update.DefaultCellStyle = dataGridViewCellStyle4;
            this.Update.HeaderText = "";
            this.Update.MinimumWidth = 4;
            this.Update.Name = "Update";
            this.Update.Text = "✍️";
            this.Update.ToolTipText = "✍️";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 125;
            // 
            // Delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 4;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "❌";
            this.Delete.ToolTipText = "❌";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // ManageSpaEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 625);
            this.Controls.Add(this.pnListSpaEmployee);
            this.Controls.Add(this.headerSpaEmployee);
            this.Text = "ManageSpaEmployeesForm";
            this.Load += new System.EventHandler(this.ManageSpaEmployeesForm_Load);
            this.pnListSpaEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpaEmployees)).EndInit();
            this.headerSpaEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RoundedPanel headerSpaEmployee;
        private System.Windows.Forms.Label lblTitleHeader;
        private CustomControls.RoundedPanel pnListSpaEmployee;
        private Guna.UI2.WinForms.Guna2Button AddNewSpaBooking;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSpaEmployees;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.DataGridViewLinkColumn EmployeeID;
        private System.Windows.Forms.DataGridViewImageColumn ImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn ChangePassword;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}