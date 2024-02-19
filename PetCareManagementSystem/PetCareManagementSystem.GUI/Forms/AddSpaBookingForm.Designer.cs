namespace PetCareManagementSystem.GUI.Forms
{
    partial class AddSpaBookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSpaBookingForm));
            this.AddSpaBookingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxEmployees = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.comboBoxServices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.llblNewPet = new System.Windows.Forms.LinkLabel();
            this.cbxPetList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblDeleteChoose = new System.Windows.Forms.LinkLabel();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.llblNewCustomer = new System.Windows.Forms.LinkLabel();
            this.comboBoxCustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.imageListRooms = new System.Windows.Forms.ImageList(this.components);
            this.AddSpaBookingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSpaBookingPanel
            // 
            this.AddSpaBookingPanel.BackColor = System.Drawing.Color.White;
            this.AddSpaBookingPanel.Controls.Add(this.btnClose);
            this.AddSpaBookingPanel.Controls.Add(this.panel1);
            this.AddSpaBookingPanel.Controls.Add(this.llblNewCustomer);
            this.AddSpaBookingPanel.Controls.Add(this.comboBoxCustomers);
            this.AddSpaBookingPanel.Controls.Add(this.label2);
            this.AddSpaBookingPanel.Controls.Add(this.label1);
            this.AddSpaBookingPanel.Controls.Add(this.listViewRooms);
            this.AddSpaBookingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSpaBookingPanel.Location = new System.Drawing.Point(0, 0);
            this.AddSpaBookingPanel.Name = "AddSpaBookingPanel";
            this.AddSpaBookingPanel.Size = new System.Drawing.Size(1153, 844);
            this.AddSpaBookingPanel.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1114, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.comboBoxEmployees);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Controls.Add(this.comboBoxServices);
            this.panel1.Controls.Add(this.lblService);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.dtpTime);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.llblNewPet);
            this.panel1.Controls.Add(this.cbxPetList);
            this.panel1.Controls.Add(this.lblPet);
            this.panel1.Controls.Add(this.lblDeleteChoose);
            this.panel1.Controls.Add(this.lblUserEmail);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblUpdateTime);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(631, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 696);
            this.panel1.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.guna2Panel1.Controls.Add(this.lblPrice);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 533);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(522, 75);
            this.guna2Panel1.TabIndex = 19;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.lblPrice.Location = new System.Drawing.Point(300, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(18, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "đ";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(189, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng số tiền";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnCancel.Image = global::PetCareManagementSystem.GUI.Properties.Resources.right_arrow_primary;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancel.Location = new System.Drawing.Point(127, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BorderRadius = 4;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PetCareManagementSystem.GUI.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(17, 639);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 45);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmployees.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxEmployees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxEmployees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxEmployees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.comboBoxEmployees.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEmployees.HoverState.ForeColor = System.Drawing.Color.White;
            this.comboBoxEmployees.ItemHeight = 30;
            this.comboBoxEmployees.Location = new System.Drawing.Point(13, 478);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(500, 36);
            this.comboBoxEmployees.TabIndex = 18;
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEmployee.Location = new System.Drawing.Point(13, 444);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(113, 20);
            this.lblEmployee.TabIndex = 17;
            this.lblEmployee.Text = "Người tắm rửa ";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxServices.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServices.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxServices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxServices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxServices.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.comboBoxServices.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxServices.HoverState.ForeColor = System.Drawing.Color.White;
            this.comboBoxServices.ItemHeight = 30;
            this.comboBoxServices.Location = new System.Drawing.Point(13, 388);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(500, 36);
            this.comboBoxServices.TabIndex = 16;
            this.comboBoxServices.SelectedIndexChanged += new System.EventHandler(this.comboBoxServices_SelectedIndexChanged);
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblService.Location = new System.Drawing.Point(13, 354);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(61, 20);
            this.lblService.TabIndex = 15;
            this.lblService.Text = "Dịch vụ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTime.Location = new System.Drawing.Point(276, 259);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 20);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Thời gian";
            // 
            // dtpTime
            // 
            this.dtpTime.Animated = true;
            this.dtpTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpTime.Checked = true;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.FillColor = System.Drawing.Color.White;
            this.dtpTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(280, 296);
            this.dtpTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(188, 43);
            this.dtpTime.TabIndex = 13;
            this.dtpTime.Value = new System.DateTime(2024, 2, 18, 21, 19, 0, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Animated = true;
            this.dtpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.White;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(17, 296);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(229, 43);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.Value = new System.DateTime(2024, 2, 18, 21, 19, 23, 567);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDate.Location = new System.Drawing.Point(10, 259);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 20);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Ngày";
            // 
            // llblNewPet
            // 
            this.llblNewPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblNewPet.AutoSize = true;
            this.llblNewPet.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNewPet.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNewPet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.llblNewPet.Location = new System.Drawing.Point(394, 173);
            this.llblNewPet.Name = "llblNewPet";
            this.llblNewPet.Size = new System.Drawing.Size(116, 17);
            this.llblNewPet.TabIndex = 10;
            this.llblNewPet.TabStop = true;
            this.llblNewPet.Text = "+ Thêm Thú cưng";
            // 
            // cbxPetList
            // 
            this.cbxPetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPetList.BackColor = System.Drawing.Color.Transparent;
            this.cbxPetList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPetList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPetList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPetList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPetList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPetList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.cbxPetList.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPetList.HoverState.ForeColor = System.Drawing.Color.White;
            this.cbxPetList.ItemHeight = 30;
            this.cbxPetList.Location = new System.Drawing.Point(10, 204);
            this.cbxPetList.Name = "cbxPetList";
            this.cbxPetList.Size = new System.Drawing.Size(500, 36);
            this.cbxPetList.TabIndex = 9;
            // 
            // lblPet
            // 
            this.lblPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPet.Location = new System.Drawing.Point(10, 170);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(113, 20);
            this.lblPet.TabIndex = 8;
            this.lblPet.Text = "Chọn Thú cưng";
            // 
            // lblDeleteChoose
            // 
            this.lblDeleteChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeleteChoose.AutoSize = true;
            this.lblDeleteChoose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteChoose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblDeleteChoose.LinkColor = System.Drawing.Color.Red;
            this.lblDeleteChoose.Location = new System.Drawing.Point(479, 32);
            this.lblDeleteChoose.Name = "lblDeleteChoose";
            this.lblDeleteChoose.Size = new System.Drawing.Size(31, 20);
            this.lblDeleteChoose.TabIndex = 7;
            this.lblDeleteChoose.TabStop = true;
            this.lblDeleteChoose.Text = "🗑️";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserEmail.Location = new System.Drawing.Point(111, 128);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(127, 20);
            this.lblUserEmail.TabIndex = 6;
            this.lblUserEmail.Text = "john@gmail.com";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPhoneNumber.Location = new System.Drawing.Point(111, 100);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(135, 20);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "+84 65 544 45 55";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(20, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Điện thoại:";
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.AutoSize = true;
            this.lblUpdateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUpdateTime.Location = new System.Drawing.Point(96, 61);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(213, 20);
            this.lblUpdateTime.TabIndex = 2;
            this.lblUpdateTime.Text = "Khách hàng từ December 2023";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(94, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(92, 28);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Lê Văn A";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::PetCareManagementSystem.GUI.Properties.Resources.profile_user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 24);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // llblNewCustomer
            // 
            this.llblNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblNewCustomer.AutoSize = true;
            this.llblNewCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNewCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNewCustomer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.llblNewCustomer.Location = new System.Drawing.Point(1059, 62);
            this.llblNewCustomer.Name = "llblNewCustomer";
            this.llblNewCustomer.Size = new System.Drawing.Size(82, 17);
            this.llblNewCustomer.TabIndex = 6;
            this.llblNewCustomer.TabStop = true;
            this.llblNewCustomer.Text = "+ Thêm mới";
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCustomers.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCustomers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.comboBoxCustomers.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCustomers.HoverState.ForeColor = System.Drawing.Color.White;
            this.comboBoxCustomers.ItemHeight = 30;
            this.comboBoxCustomers.Location = new System.Drawing.Point(638, 93);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(503, 36);
            this.comboBoxCustomers.TabIndex = 5;
            this.comboBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(640, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn Khách hàng";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tạo mới Đặt chỗ Tắm rửa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.LargeImageList = this.imageListRooms;
            this.listViewRooms.Location = new System.Drawing.Point(0, 0);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(632, 844);
            this.listViewRooms.SmallImageList = this.imageListRooms;
            this.listViewRooms.TabIndex = 2;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            // 
            // imageListRooms
            // 
            this.imageListRooms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRooms.ImageStream")));
            this.imageListRooms.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRooms.Images.SetKeyName(0, "dog-green.png");
            this.imageListRooms.Images.SetKeyName(1, "dog-red.png");
            // 
            // AddSpaBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 844);
            this.Controls.Add(this.AddSpaBookingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSpaBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSpaBookingForm";
            this.Load += new System.EventHandler(this.AddSpaBookingForm_Load);
            this.AddSpaBookingPanel.ResumeLayout(false);
            this.AddSpaBookingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel AddSpaBookingPanel;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ImageList imageListRooms;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llblNewCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblUpdateTime;
        private System.Windows.Forms.Label lblCustomerName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.LinkLabel lblDeleteChoose;
        private System.Windows.Forms.LinkLabel llblNewPet;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPetList;
        private System.Windows.Forms.Label lblPet;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxEmployees;
        private System.Windows.Forms.Label lblEmployee;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxServices;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}