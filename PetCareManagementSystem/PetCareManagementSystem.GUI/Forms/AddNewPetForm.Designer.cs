namespace PetCareManagementSystem.GUI.Forms
{
    partial class AddNewPetForm
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTextDanger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdoMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.picCustomer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnUploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEmployeeInfo = new System.Windows.Forms.Panel();
            this.cbxTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxBreed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlAction.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.pnlEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(15, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 45);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(120, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(117, 45);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAction
            // 
            this.pnlAction.BackColor = System.Drawing.Color.White;
            this.pnlAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAction.Controls.Add(this.btnSave);
            this.pnlAction.Controls.Add(this.btnCancel);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 705);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(800, 72);
            this.pnlAction.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.closed;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClose.Image = global::PetCareManagementSystem.GUI.Properties.Resources.closed;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClose.Location = new System.Drawing.Point(755, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.closed;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(282, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tạo mới Thú Cưng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(800, 72);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.lblLastName.Location = new System.Drawing.Point(26, 191);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(36, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Tên";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(30, 224);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(685, 38);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.lblFirstName.Location = new System.Drawing.Point(26, 276);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 23);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Loại thú cưng";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.lblEmail.Location = new System.Drawing.Point(26, 361);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 23);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Giống";
            // 
            // lblTextDanger
            // 
            this.lblTextDanger.AutoSize = true;
            this.lblTextDanger.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTextDanger.ForeColor = System.Drawing.Color.Red;
            this.lblTextDanger.Location = new System.Drawing.Point(62, 191);
            this.lblTextDanger.Name = "lblTextDanger";
            this.lblTextDanger.Size = new System.Drawing.Size(17, 23);
            this.lblTextDanger.TabIndex = 15;
            this.lblTextDanger.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(148, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "*";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdoMale);
            this.pnlGender.Controls.Add(this.rdoFemale);
            this.pnlGender.Location = new System.Drawing.Point(30, 665);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(200, 45);
            this.pnlGender.TabIndex = 34;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.rdoMale.Checked = true;
            this.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.rdoMale.CheckedState.BorderThickness = 0;
            this.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMale.CheckedState.InnerOffset = -3;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rdoMale.ForeColor = System.Drawing.Color.Black;
            this.rdoMale.Location = new System.Drawing.Point(20, 14);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 32;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMale.UncheckedState.BorderThickness = 4;
            this.rdoMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.rdoFemale.CheckedState.BorderThickness = 0;
            this.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoFemale.CheckedState.InnerOffset = -3;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.rdoFemale.Location = new System.Drawing.Point(106, 14);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 33;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoFemale.UncheckedState.BorderThickness = 3;
            this.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::PetCareManagementSystem.GUI.Properties.Resources._default;
            this.picCustomer.ImageRotate = 0F;
            this.picCustomer.Location = new System.Drawing.Point(265, 5);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picCustomer.Size = new System.Drawing.Size(211, 136);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCustomer.TabIndex = 35;
            this.picCustomer.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BorderRadius = 4;
            this.btnUploadImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(223)))), ((int)(((byte)(252)))));
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnUploadImage.Location = new System.Drawing.Point(314, 147);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(120, 45);
            this.btnUploadImage.TabIndex = 36;
            this.btnUploadImage.Text = "Tải lên";
            // 
            // pnlEmployeeInfo
            // 
            this.pnlEmployeeInfo.AutoScroll = true;
            this.pnlEmployeeInfo.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.pnlEmployeeInfo.BackColor = System.Drawing.Color.White;
            this.pnlEmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeeInfo.Controls.Add(this.dtpBirthDay);
            this.pnlEmployeeInfo.Controls.Add(this.txtAge);
            this.pnlEmployeeInfo.Controls.Add(this.label7);
            this.pnlEmployeeInfo.Controls.Add(this.label5);
            this.pnlEmployeeInfo.Controls.Add(this.cbxTypes);
            this.pnlEmployeeInfo.Controls.Add(this.cbxBreed);
            this.pnlEmployeeInfo.Controls.Add(this.label2);
            this.pnlEmployeeInfo.Controls.Add(this.btnUploadImage);
            this.pnlEmployeeInfo.Controls.Add(this.picCustomer);
            this.pnlEmployeeInfo.Controls.Add(this.pnlGender);
            this.pnlEmployeeInfo.Controls.Add(this.lblGender);
            this.pnlEmployeeInfo.Controls.Add(this.label1);
            this.pnlEmployeeInfo.Controls.Add(this.lblTextDanger);
            this.pnlEmployeeInfo.Controls.Add(this.lblEmail);
            this.pnlEmployeeInfo.Controls.Add(this.lblFirstName);
            this.pnlEmployeeInfo.Controls.Add(this.txtLastName);
            this.pnlEmployeeInfo.Controls.Add(this.lblLastName);
            this.pnlEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeInfo.Location = new System.Drawing.Point(0, 72);
            this.pnlEmployeeInfo.Name = "pnlEmployeeInfo";
            this.pnlEmployeeInfo.Size = new System.Drawing.Size(800, 633);
            this.pnlEmployeeInfo.TabIndex = 6;
            // 
            // cbxTypes
            // 
            this.cbxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTypes.ItemHeight = 30;
            this.cbxTypes.Location = new System.Drawing.Point(30, 313);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(685, 36);
            this.cbxTypes.TabIndex = 39;
            this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTypes_SelectedIndexChanged);
            // 
            // cbxBreed
            // 
            this.cbxBreed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBreed.BackColor = System.Drawing.Color.Transparent;
            this.cbxBreed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBreed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBreed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBreed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxBreed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxBreed.ItemHeight = 30;
            this.cbxBreed.Location = new System.Drawing.Point(30, 399);
            this.cbxBreed.Name = "cbxBreed";
            this.cbxBreed.Size = new System.Drawing.Size(685, 36);
            this.cbxBreed.TabIndex = 38;
            this.cbxBreed.SelectedIndexChanged += new System.EventHandler(this.cbxBreed_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(93, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "*";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.lblGender.Location = new System.Drawing.Point(33, 630);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 23);
            this.lblGender.TabIndex = 31;
            this.lblGender.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(26, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAge.Location = new System.Drawing.Point(30, 577);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderText = "";
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(685, 38);
            this.txtAge.TabIndex = 44;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(26, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tuổi";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Checked = true;
            this.dtpBirthDay.FillColor = System.Drawing.Color.White;
            this.dtpBirthDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDay.Location = new System.Drawing.Point(30, 489);
            this.dtpBirthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(685, 41);
            this.dtpBirthDay.TabIndex = 45;
            this.dtpBirthDay.Value = new System.DateTime(2024, 2, 23, 9, 22, 34, 77);
            // 
            // AddNewPetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 777);
            this.Controls.Add(this.pnlEmployeeInfo);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlTitle);
            this.Name = "AddNewPetForm";
            this.Text = "AddNewPetForm";
            this.Load += new System.EventHandler(this.AddNewPetForm_Load);
            this.pnlAction.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.pnlEmployeeInfo.ResumeLayout(false);
            this.pnlEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Panel pnlAction;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTextDanger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGender;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMale;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFemale;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picCustomer;
        private Guna.UI2.WinForms.Guna2Button btnUploadImage;
        private System.Windows.Forms.Panel pnlEmployeeInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypes;
        private Guna.UI2.WinForms.Guna2ComboBox cbxBreed;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDay;
    }
}