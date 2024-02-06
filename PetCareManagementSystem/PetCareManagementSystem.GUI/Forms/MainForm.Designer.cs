namespace PetCareManagementSystem.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.GroomingContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnArrowDown = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSpaTypes = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrooming = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBookingService = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserName = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTime = new System.Windows.Forms.Timer(this.components);
            this.GroomingTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.sidebarContainer.SuspendLayout();
            this.GroomingContainer.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.menuButton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1203, 40);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(1068, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(135, 40);
            this.guna2Panel2.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClose.Location = new System.Drawing.Point(90, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 40);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.guna2ControlBox2.Location = new System.Drawing.Point(45, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 40);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Care System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FillColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = global::PetCareManagementSystem.GUI.Properties.Resources.icon_menu;
            this.menuButton.ImageRotate = 0F;
            this.menuButton.Location = new System.Drawing.Point(12, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(20, 20);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btnDashBoard);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(286, 55);
            this.guna2Panel3.TabIndex = 3;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Checked = true;
            this.btnDashBoard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnDashBoard.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.dashboard_icon_white;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashBoard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashBoard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashBoard.FillColor = System.Drawing.Color.White;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.Black;
            this.btnDashBoard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnDashBoard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnDashBoard.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnDashBoard.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.dashboard_icon_hover;
            this.btnDashBoard.Image = global::PetCareManagementSystem.GUI.Properties.Resources.dashboard_icon;
            this.btnDashBoard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashBoard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(271, 55);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "Bảng Điều Khiển";
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.White;
            this.sidebarContainer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sidebarContainer.Controls.Add(this.GroomingContainer);
            this.sidebarContainer.Controls.Add(this.guna2Panel4);
            this.sidebarContainer.Controls.Add(this.guna2Panel6);
            this.sidebarContainer.Controls.Add(this.guna2Panel5);
            this.sidebarContainer.Controls.Add(this.guna2Panel3);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 40);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(286, 0);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(71, 0);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(286, 613);
            this.sidebarContainer.TabIndex = 2;
            // 
            // GroomingContainer
            // 
            this.GroomingContainer.Controls.Add(this.btnArrowDown);
            this.GroomingContainer.Controls.Add(this.btnSpaTypes);
            this.GroomingContainer.Controls.Add(this.btnSpaCategory);
            this.GroomingContainer.Controls.Add(this.btnSpaEmployee);
            this.GroomingContainer.Controls.Add(this.btnSpaOrder);
            this.GroomingContainer.Controls.Add(this.btnGrooming);
            this.GroomingContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroomingContainer.Location = new System.Drawing.Point(0, 110);
            this.GroomingContainer.MaximumSize = new System.Drawing.Size(286, 275);
            this.GroomingContainer.MinimumSize = new System.Drawing.Size(286, 55);
            this.GroomingContainer.Name = "GroomingContainer";
            this.GroomingContainer.Size = new System.Drawing.Size(286, 55);
            this.GroomingContainer.TabIndex = 6;
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.BackColor = System.Drawing.Color.White;
            this.btnArrowDown.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnArrowDown.HoverState.ImageSize = new System.Drawing.Size(25, 20);
            this.btnArrowDown.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow_down;
            this.btnArrowDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnArrowDown.ImageRotate = 0F;
            this.btnArrowDown.ImageSize = new System.Drawing.Size(20, 20);
            this.btnArrowDown.Location = new System.Drawing.Point(237, 18);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(25, 20);
            this.btnArrowDown.TabIndex = 3;
            // 
            // btnSpaTypes
            // 
            this.btnSpaTypes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaTypes.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaTypes.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSpaTypes.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.btnSpaTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpaTypes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaTypes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaTypes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpaTypes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpaTypes.FillColor = System.Drawing.Color.White;
            this.btnSpaTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaTypes.ForeColor = System.Drawing.Color.Black;
            this.btnSpaTypes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaTypes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnSpaTypes.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaTypes.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaTypes.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.btnSpaTypes.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.btnSpaTypes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpaTypes.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnSpaTypes.Location = new System.Drawing.Point(0, 221);
            this.btnSpaTypes.Name = "btnSpaTypes";
            this.btnSpaTypes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSpaTypes.Size = new System.Drawing.Size(271, 55);
            this.btnSpaTypes.TabIndex = 6;
            this.btnSpaTypes.Text = "Các Dịch Vụ";
            // 
            // btnSpaCategory
            // 
            this.btnSpaCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaCategory.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaCategory.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSpaCategory.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.btnSpaCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpaCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpaCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpaCategory.FillColor = System.Drawing.Color.White;
            this.btnSpaCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaCategory.ForeColor = System.Drawing.Color.Black;
            this.btnSpaCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaCategory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnSpaCategory.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaCategory.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaCategory.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.btnSpaCategory.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.btnSpaCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpaCategory.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnSpaCategory.Location = new System.Drawing.Point(0, 166);
            this.btnSpaCategory.Name = "btnSpaCategory";
            this.btnSpaCategory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSpaCategory.Size = new System.Drawing.Size(271, 55);
            this.btnSpaCategory.TabIndex = 5;
            this.btnSpaCategory.Text = "Danh Mục";
            // 
            // btnSpaEmployee
            // 
            this.btnSpaEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaEmployee.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaEmployee.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSpaEmployee.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.bag_white;
            this.btnSpaEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpaEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpaEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpaEmployee.FillColor = System.Drawing.Color.White;
            this.btnSpaEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnSpaEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnSpaEmployee.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaEmployee.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaEmployee.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.bag_primary;
            this.btnSpaEmployee.Image = global::PetCareManagementSystem.GUI.Properties.Resources.bag;
            this.btnSpaEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpaEmployee.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnSpaEmployee.Location = new System.Drawing.Point(0, 111);
            this.btnSpaEmployee.Name = "btnSpaEmployee";
            this.btnSpaEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSpaEmployee.Size = new System.Drawing.Size(271, 55);
            this.btnSpaEmployee.TabIndex = 4;
            this.btnSpaEmployee.Text = "Nhân Viên Spa";
            // 
            // btnSpaOrder
            // 
            this.btnSpaOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaOrder.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaOrder.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSpaOrder.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.btnSpaOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpaOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpaOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpaOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpaOrder.FillColor = System.Drawing.Color.White;
            this.btnSpaOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSpaOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnSpaOrder.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaOrder.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnSpaOrder.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.btnSpaOrder.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.btnSpaOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSpaOrder.ImageOffset = new System.Drawing.Point(25, 0);
            this.btnSpaOrder.Location = new System.Drawing.Point(0, 56);
            this.btnSpaOrder.Name = "btnSpaOrder";
            this.btnSpaOrder.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSpaOrder.Size = new System.Drawing.Size(271, 55);
            this.btnSpaOrder.TabIndex = 3;
            this.btnSpaOrder.Text = "Đơn Đặt Spa";
            this.btnSpaOrder.Click += new System.EventHandler(this.btnSpaOrder_Click);
            // 
            // btnGrooming
            // 
            this.btnGrooming.BackColor = System.Drawing.Color.Transparent;
            this.btnGrooming.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnGrooming.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrooming.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnGrooming.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper_white;
            this.btnGrooming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrooming.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrooming.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrooming.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrooming.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrooming.FillColor = System.Drawing.Color.White;
            this.btnGrooming.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrooming.ForeColor = System.Drawing.Color.Black;
            this.btnGrooming.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnGrooming.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnGrooming.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrooming.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnGrooming.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper_primary;
            this.btnGrooming.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper;
            this.btnGrooming.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGrooming.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnGrooming.Location = new System.Drawing.Point(0, 0);
            this.btnGrooming.Name = "btnGrooming";
            this.btnGrooming.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGrooming.Size = new System.Drawing.Size(271, 55);
            this.btnGrooming.TabIndex = 2;
            this.btnGrooming.Text = "Dịch Vụ Spa Cắt Tỉa";
            this.btnGrooming.Click += new System.EventHandler(this.btnGrooming_Click);
            this.btnGrooming.MouseLeave += new System.EventHandler(this.btnGrooming_MouseLeave);
            this.btnGrooming.MouseHover += new System.EventHandler(this.btnGrooming_MouseHover);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btnBookingService);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 55);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(286, 55);
            this.guna2Panel4.TabIndex = 5;
            // 
            // btnBookingService
            // 
            this.btnBookingService.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnBookingService.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingService.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBookingService.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.calendar_white;
            this.btnBookingService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookingService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookingService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookingService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookingService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookingService.FillColor = System.Drawing.Color.White;
            this.btnBookingService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingService.ForeColor = System.Drawing.Color.Black;
            this.btnBookingService.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnBookingService.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnBookingService.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingService.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnBookingService.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.calendar_primary;
            this.btnBookingService.Image = global::PetCareManagementSystem.GUI.Properties.Resources.calendar;
            this.btnBookingService.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookingService.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnBookingService.Location = new System.Drawing.Point(0, 0);
            this.btnBookingService.Name = "btnBookingService";
            this.btnBookingService.Size = new System.Drawing.Size(271, 55);
            this.btnBookingService.TabIndex = 2;
            this.btnBookingService.Text = "Đơn Đặt Dịch Vụ";
            this.btnBookingService.Click += new System.EventHandler(this.btnBookingService_Click);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.btnUserName);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 503);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(286, 55);
            this.guna2Panel6.TabIndex = 4;
            // 
            // btnUserName
            // 
            this.btnUserName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnUserName.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUserName.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.id_card_white;
            this.btnUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserName.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserName.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserName.FillColor = System.Drawing.Color.White;
            this.btnUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.ForeColor = System.Drawing.Color.Black;
            this.btnUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnUserName.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnUserName.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnUserName.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.id_card_primary;
            this.btnUserName.Image = global::PetCareManagementSystem.GUI.Properties.Resources.id_card;
            this.btnUserName.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserName.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnUserName.Location = new System.Drawing.Point(3, 0);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(268, 55);
            this.btnUserName.TabIndex = 2;
            this.btnUserName.Text = "Demo Amin";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.btnLogout);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 558);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(286, 55);
            this.guna2Panel5.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnLogout.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.logout_white;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.btnLogout.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.btnLogout.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnLogout.Image = global::PetCareManagementSystem.GUI.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(271, 55);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebarTime
            // 
            this.sidebarTime.Interval = 10;
            this.sidebarTime.Tick += new System.EventHandler(this.sidebarTime_Tick);
            // 
            // GroomingTimer
            // 
            this.GroomingTimer.Interval = 10;
            this.GroomingTimer.Tick += new System.EventHandler(this.GroomingTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 653);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.sidebarContainer.ResumeLayout(false);
            this.GroomingContainer.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel sidebarContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button btnUserName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Timer sidebarTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnBookingService;
        private Guna.UI2.WinForms.Guna2Panel GroomingContainer;
        private Guna.UI2.WinForms.Guna2Button btnSpaOrder;
        private Guna.UI2.WinForms.Guna2Button btnGrooming;
        private Guna.UI2.WinForms.Guna2Button btnSpaTypes;
        private Guna.UI2.WinForms.Guna2Button btnSpaCategory;
        private Guna.UI2.WinForms.Guna2Button btnSpaEmployee;
        private System.Windows.Forms.Timer GroomingTimer;
        private Guna.UI2.WinForms.Guna2ImageButton btnArrowDown;
    }
}