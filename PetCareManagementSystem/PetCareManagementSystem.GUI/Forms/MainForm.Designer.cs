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
            this.HeaderRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TitleHeaderName = new System.Windows.Forms.Label();
            this.DashboardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.BookingServicePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBookingService = new Guna.UI2.WinForms.Guna2Button();
            this.UserStatusPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserName = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.SidebarTime = new System.Windows.Forms.Timer(this.components);
            this.GroomingTimer = new System.Windows.Forms.Timer(this.components);
            this.ToolbarPanel = new System.Windows.Forms.Panel();
            this.menuButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.GroomingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnArrowDown = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSpaTypes = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpaOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnGrooming = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnManRec = new Guna.UI2.WinForms.Guna2Button();
            this.btnArD = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnManageReceipt = new Guna.UI2.WinForms.Guna2Button();
            this.ManagePro = new Guna.UI2.WinForms.Guna2Button();
            this.timerbtnRec = new System.Windows.Forms.Timer(this.components);
            this.HeaderRightPanel.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.BookingServicePanel.SuspendLayout();
            this.UserStatusPanel.SuspendLayout();
            this.LogoutPanel.SuspendLayout();
            this.ToolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SideMenuPanel.SuspendLayout();
            this.GroomingPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderRightPanel
            // 
            this.HeaderRightPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderRightPanel.Controls.Add(this.btnClose);
            this.HeaderRightPanel.Controls.Add(this.MinimizeBox);
            this.HeaderRightPanel.Controls.Add(this.MaximizeBox);
            this.HeaderRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HeaderRightPanel.Location = new System.Drawing.Point(1068, 0);
            this.HeaderRightPanel.Name = "HeaderRightPanel";
            this.HeaderRightPanel.Size = new System.Drawing.Size(135, 40);
            this.HeaderRightPanel.TabIndex = 4;
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
            // MinimizeBox
            // 
            this.MinimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBox.Animated = true;
            this.MinimizeBox.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBox.FillColor = System.Drawing.Color.White;
            this.MinimizeBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.MinimizeBox.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(45, 40);
            this.MinimizeBox.TabIndex = 3;
            // 
            // MaximizeBox
            // 
            this.MaximizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBox.Animated = true;
            this.MaximizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeBox.FillColor = System.Drawing.Color.White;
            this.MaximizeBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.MaximizeBox.Location = new System.Drawing.Point(45, 0);
            this.MaximizeBox.Name = "MaximizeBox";
            this.MaximizeBox.Size = new System.Drawing.Size(45, 40);
            this.MaximizeBox.TabIndex = 2;
            // 
            // TitleHeaderName
            // 
            this.TitleHeaderName.BackColor = System.Drawing.Color.Transparent;
            this.TitleHeaderName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHeaderName.Location = new System.Drawing.Point(41, 0);
            this.TitleHeaderName.Name = "TitleHeaderName";
            this.TitleHeaderName.Size = new System.Drawing.Size(163, 40);
            this.TitleHeaderName.TabIndex = 1;
            this.TitleHeaderName.Text = "Pet Care System";
            this.TitleHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Controls.Add(this.btnDashBoard);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(286, 55);
            this.DashboardPanel.TabIndex = 3;
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
            // BookingServicePanel
            // 
            this.BookingServicePanel.Controls.Add(this.btnBookingService);
            this.BookingServicePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookingServicePanel.Location = new System.Drawing.Point(0, 55);
            this.BookingServicePanel.Name = "BookingServicePanel";
            this.BookingServicePanel.Size = new System.Drawing.Size(286, 55);
            this.BookingServicePanel.TabIndex = 5;
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
            // UserStatusPanel
            // 
            this.UserStatusPanel.Controls.Add(this.btnUserName);
            this.UserStatusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserStatusPanel.Location = new System.Drawing.Point(0, 503);
            this.UserStatusPanel.Name = "UserStatusPanel";
            this.UserStatusPanel.Size = new System.Drawing.Size(286, 55);
            this.UserStatusPanel.TabIndex = 4;
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
            // LogoutPanel
            // 
            this.LogoutPanel.Controls.Add(this.btnLogout);
            this.LogoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogoutPanel.Location = new System.Drawing.Point(0, 558);
            this.LogoutPanel.Name = "LogoutPanel";
            this.LogoutPanel.Size = new System.Drawing.Size(286, 55);
            this.LogoutPanel.TabIndex = 4;
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
            // SidebarTime
            // 
            this.SidebarTime.Interval = 10;
            this.SidebarTime.Tick += new System.EventHandler(this.SidebarTime_Tick);
            // 
            // GroomingTimer
            // 
            this.GroomingTimer.Interval = 10;
            this.GroomingTimer.Tick += new System.EventHandler(this.GroomingTimer_Tick);
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.BackColor = System.Drawing.Color.White;
            this.ToolbarPanel.Controls.Add(this.HeaderRightPanel);
            this.ToolbarPanel.Controls.Add(this.menuButton);
            this.ToolbarPanel.Controls.Add(this.TitleHeaderName);
            this.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolbarPanel.Name = "ToolbarPanel";
            this.ToolbarPanel.Size = new System.Drawing.Size(1203, 40);
            this.ToolbarPanel.TabIndex = 4;
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FillColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = global::PetCareManagementSystem.GUI.Properties.Resources.icon_menu;
            this.menuButton.ImageRotate = 0F;
            this.menuButton.Location = new System.Drawing.Point(15, 10);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(20, 20);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.White;
            this.SideMenuPanel.Controls.Add(this.GroomingPanel);
            this.SideMenuPanel.Controls.Add(this.guna2Panel1);
            this.SideMenuPanel.Controls.Add(this.UserStatusPanel);
            this.SideMenuPanel.Controls.Add(this.LogoutPanel);
            this.SideMenuPanel.Controls.Add(this.BookingServicePanel);
            this.SideMenuPanel.Controls.Add(this.DashboardPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.SideMenuPanel.MaximumSize = new System.Drawing.Size(286, 0);
            this.SideMenuPanel.MinimumSize = new System.Drawing.Size(71, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(286, 613);
            this.SideMenuPanel.TabIndex = 5;
            // 
            // GroomingPanel
            // 
            this.GroomingPanel.Controls.Add(this.btnArrowDown);
            this.GroomingPanel.Controls.Add(this.btnSpaTypes);
            this.GroomingPanel.Controls.Add(this.btnSpaCategory);
            this.GroomingPanel.Controls.Add(this.btnSpaEmployee);
            this.GroomingPanel.Controls.Add(this.btnSpaOrder);
            this.GroomingPanel.Controls.Add(this.btnGrooming);
            this.GroomingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroomingPanel.Location = new System.Drawing.Point(0, 110);
            this.GroomingPanel.MaximumSize = new System.Drawing.Size(286, 275);
            this.GroomingPanel.MinimumSize = new System.Drawing.Size(286, 55);
            this.GroomingPanel.Name = "GroomingPanel";
            this.GroomingPanel.Size = new System.Drawing.Size(286, 63);
            this.GroomingPanel.TabIndex = 11;
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
            this.btnSpaEmployee.Click += new System.EventHandler(this.btnSpaEmployee_Click);
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
            this.btnGrooming.Size = new System.Drawing.Size(271, 61);
            this.btnGrooming.TabIndex = 2;
            this.btnGrooming.Text = "Dịch Vụ Spa Cắt Tỉa";
            this.btnGrooming.Click += new System.EventHandler(this.btnGrooming_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.BtnManRec);
            this.guna2Panel1.Controls.Add(this.btnArD);
            this.guna2Panel1.Controls.Add(this.BtnManageReceipt);
            this.guna2Panel1.Controls.Add(this.ManagePro);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 177);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(268, 68);
            this.guna2Panel1.TabIndex = 10;
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.guna2Panel1_MouseLeave);
            this.guna2Panel1.MouseHover += new System.EventHandler(this.guna2Panel1_MouseHover);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.guna2Button1.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.guna2Button1.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.guna2Button1.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(25, 0);
            this.guna2Button1.Location = new System.Drawing.Point(-3, 175);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.guna2Button1.Size = new System.Drawing.Size(271, 46);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Manage Category";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnManRec
            // 
            this.BtnManRec.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManRec.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManRec.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnManRec.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.BtnManRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnManRec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnManRec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnManRec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnManRec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnManRec.FillColor = System.Drawing.Color.White;
            this.BtnManRec.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnManRec.ForeColor = System.Drawing.Color.Black;
            this.BtnManRec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManRec.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.BtnManRec.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManRec.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManRec.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.BtnManRec.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.BtnManRec.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnManRec.ImageOffset = new System.Drawing.Point(25, 0);
            this.BtnManRec.Location = new System.Drawing.Point(3, 71);
            this.BtnManRec.Name = "BtnManRec";
            this.BtnManRec.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnManRec.Size = new System.Drawing.Size(271, 46);
            this.BtnManRec.TabIndex = 11;
            this.BtnManRec.Text = "Manage Receipt";
            this.BtnManRec.Click += new System.EventHandler(this.BtnManRec_Click_1);
            // 
            // btnArD
            // 
            this.btnArD.BackColor = System.Drawing.Color.White;
            this.btnArD.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnArD.HoverState.ImageSize = new System.Drawing.Size(25, 20);
            this.btnArD.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow_down;
            this.btnArD.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnArD.ImageRotate = 0F;
            this.btnArD.ImageSize = new System.Drawing.Size(20, 20);
            this.btnArD.Location = new System.Drawing.Point(234, 24);
            this.btnArD.Name = "btnArD";
            this.btnArD.Size = new System.Drawing.Size(25, 20);
            this.btnArD.TabIndex = 10;
            // 
            // BtnManageReceipt
            // 
            this.BtnManageReceipt.BackColor = System.Drawing.Color.Transparent;
            this.BtnManageReceipt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManageReceipt.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageReceipt.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnManageReceipt.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper_white;
            this.BtnManageReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnManageReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnManageReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnManageReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnManageReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnManageReceipt.FillColor = System.Drawing.Color.White;
            this.BtnManageReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageReceipt.ForeColor = System.Drawing.Color.Black;
            this.BtnManageReceipt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManageReceipt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.BtnManageReceipt.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageReceipt.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.BtnManageReceipt.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper_primary;
            this.BtnManageReceipt.Image = global::PetCareManagementSystem.GUI.Properties.Resources.hair_clipper;
            this.BtnManageReceipt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnManageReceipt.ImageOffset = new System.Drawing.Point(10, 0);
            this.BtnManageReceipt.Location = new System.Drawing.Point(0, 10);
            this.BtnManageReceipt.Name = "BtnManageReceipt";
            this.BtnManageReceipt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnManageReceipt.Size = new System.Drawing.Size(271, 55);
            this.BtnManageReceipt.TabIndex = 7;
            this.BtnManageReceipt.Text = "Phiếu Nhập Kho";
            this.BtnManageReceipt.Click += new System.EventHandler(this.BtnManageReceipt_Click);
            // 
            // ManagePro
            // 
            this.ManagePro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.ManagePro.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePro.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ManagePro.CheckedState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_white;
            this.ManagePro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagePro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ManagePro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ManagePro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ManagePro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ManagePro.FillColor = System.Drawing.Color.White;
            this.ManagePro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ManagePro.ForeColor = System.Drawing.Color.Black;
            this.ManagePro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.ManagePro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            this.ManagePro.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePro.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.ManagePro.HoverState.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders_primary;
            this.ManagePro.Image = global::PetCareManagementSystem.GUI.Properties.Resources.settings_sliders;
            this.ManagePro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ManagePro.ImageOffset = new System.Drawing.Point(25, 0);
            this.ManagePro.Location = new System.Drawing.Point(0, 123);
            this.ManagePro.Name = "ManagePro";
            this.ManagePro.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ManagePro.Size = new System.Drawing.Size(271, 46);
            this.ManagePro.TabIndex = 7;
            this.ManagePro.Text = "Manage Product";
            this.ManagePro.Click += new System.EventHandler(this.ManagePro_Click);
            // 
            // timerbtnRec
            // 
            this.timerbtnRec.Tick += new System.EventHandler(this.timerbtnRec_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 653);
            this.Controls.Add(this.SideMenuPanel);
            this.Controls.Add(this.ToolbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HeaderRightPanel.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.BookingServicePanel.ResumeLayout(false);
            this.UserStatusPanel.ResumeLayout(false);
            this.LogoutPanel.ResumeLayout(false);
            this.ToolbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.SideMenuPanel.ResumeLayout(false);
            this.GroomingPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox menuButton;
        private System.Windows.Forms.Label TitleHeaderName;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBox;
        private Guna.UI2.WinForms.Guna2Panel HeaderRightPanel;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Panel DashboardPanel;
        private Guna.UI2.WinForms.Guna2Panel LogoutPanel;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel UserStatusPanel;
        private Guna.UI2.WinForms.Guna2Button btnUserName;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Timer SidebarTime;
        private Guna.UI2.WinForms.Guna2Panel BookingServicePanel;
        private Guna.UI2.WinForms.Guna2Button btnBookingService;
        private System.Windows.Forms.Timer GroomingTimer;
        private System.Windows.Forms.Panel ToolbarPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private Guna.UI2.WinForms.Guna2Button BtnManageReceipt;
        private System.Windows.Forms.Timer timerbtnRec;
        private Guna.UI2.WinForms.Guna2Button ManagePro;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnArD;
        private Guna.UI2.WinForms.Guna2Panel GroomingPanel;
        private Guna.UI2.WinForms.Guna2ImageButton btnArrowDown;
        private Guna.UI2.WinForms.Guna2Button btnSpaTypes;
        private Guna.UI2.WinForms.Guna2Button btnSpaCategory;
        private Guna.UI2.WinForms.Guna2Button btnSpaEmployee;
        private Guna.UI2.WinForms.Guna2Button btnSpaOrder;
        private Guna.UI2.WinForms.Guna2Button btnGrooming;
        private Guna.UI2.WinForms.Guna2Button BtnManRec;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}