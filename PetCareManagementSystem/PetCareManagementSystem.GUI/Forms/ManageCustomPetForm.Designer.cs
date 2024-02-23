namespace PetCareManagementSystem.GUI.Forms
{
    partial class ManageCustomPetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitleHeader = new System.Windows.Forms.Label();
            this.headerSpaEmployee = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.pnListCustomerPet = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.dataGridViewCustomerPet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ImageURL = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petCountColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.addButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddNewSpaBooking = new Guna.UI2.WinForms.Guna2Button();
            this.headerSpaEmployee.SuspendLayout();
            this.pnListCustomerPet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerPet)).BeginInit();
            this.SuspendLayout();
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
            this.lblTitleHeader.Text = "Chủ Nhân và Thú Cưng";
            this.lblTitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.headerSpaEmployee.TabIndex = 5;
            // 
            // pnListCustomerPet
            // 
            this.pnListCustomerPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnListCustomerPet.BackColor = System.Drawing.Color.White;
            this.pnListCustomerPet.Controls.Add(this.dataGridViewCustomerPet);
            this.pnListCustomerPet.Controls.Add(this.AddNewSpaBooking);
            this.pnListCustomerPet.Location = new System.Drawing.Point(21, 77);
            this.pnListCustomerPet.Name = "pnListCustomerPet";
            this.pnListCustomerPet.Radius = 20;
            this.pnListCustomerPet.Size = new System.Drawing.Size(1128, 531);
            this.pnListCustomerPet.TabIndex = 6;
            // 
            // dataGridViewCustomerPet
            // 
            this.dataGridViewCustomerPet.AllowUserToAddRows = false;
            this.dataGridViewCustomerPet.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewCustomerPet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomerPet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomerPet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomerPet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomerPet.ColumnHeadersHeight = 50;
            this.dataGridViewCustomerPet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.ImageURL,
            this.Name,
            this.Email,
            this.PhoneNumber,
            this.petCountColumn,
            this.addButtonColumn,
            this.UpdateTime,
            this.Gender,
            this.ChangePassword,
            this.Update,
            this.Delete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomerPet.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewCustomerPet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCustomerPet.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewCustomerPet.Name = "dataGridViewCustomerPet";
            this.dataGridViewCustomerPet.RowHeadersVisible = false;
            this.dataGridViewCustomerPet.RowHeadersWidth = 40;
            this.dataGridViewCustomerPet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCustomerPet.RowTemplate.Height = 50;
            this.dataGridViewCustomerPet.Size = new System.Drawing.Size(1128, 454);
            this.dataGridViewCustomerPet.TabIndex = 3;
            this.dataGridViewCustomerPet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCustomerPet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewCustomerPet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCustomerPet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewCustomerPet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewCustomerPet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCustomerPet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomerPet.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridViewCustomerPet.ThemeStyle.ReadOnly = false;
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.Height = 50;
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewCustomerPet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewCustomerPet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerPet_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CustomerID.Width = 161;
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
            // petCountColumn
            // 
            this.petCountColumn.ActiveLinkColor = System.Drawing.Color.Gray;
            this.petCountColumn.DataPropertyName = "NumberOfPets";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.petCountColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.petCountColumn.HeaderText = "Số lượng thú cưng";
            this.petCountColumn.LinkColor = System.Drawing.Color.Gray;
            this.petCountColumn.MinimumWidth = 6;
            this.petCountColumn.Name = "petCountColumn";
            this.petCountColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.petCountColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.petCountColumn.Width = 170;
            // 
            // addButtonColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.addButtonColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.addButtonColumn.HeaderText = "";
            this.addButtonColumn.MinimumWidth = 6;
            this.addButtonColumn.Name = "addButtonColumn";
            this.addButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addButtonColumn.Text = "+";
            this.addButtonColumn.UseColumnTextForButtonValue = true;
            this.addButtonColumn.Width = 90;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "Đã Cập Nhật Lúc";
            this.UpdateTime.MinimumWidth = 6;
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Width = 161;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Gender.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // ChangePassword
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.ChangePassword.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Update.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle8;
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
            // ManageCustomPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 625);
            this.Controls.Add(this.pnListCustomerPet);
            this.Controls.Add(this.headerSpaEmployee);
            this.Text = "ManageCustomPetForm";
            this.Load += new System.EventHandler(this.ManageCustomPetForm_Load);
            this.headerSpaEmployee.ResumeLayout(false);
            this.pnListCustomerPet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHeader;
        private CustomControls.RoundedPanel headerSpaEmployee;
        private CustomControls.RoundedPanel pnListCustomerPet;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewCustomerPet;
        private Guna.UI2.WinForms.Guna2Button AddNewSpaBooking;
        private System.Windows.Forms.DataGridViewLinkColumn CustomerID;
        private System.Windows.Forms.DataGridViewImageColumn ImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewLinkColumn petCountColumn;
        private System.Windows.Forms.DataGridViewButtonColumn addButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewButtonColumn ChangePassword;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}