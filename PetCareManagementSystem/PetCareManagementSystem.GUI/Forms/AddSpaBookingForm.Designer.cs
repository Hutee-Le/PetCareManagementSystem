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
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.imageListRooms = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddSpaBookingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSpaBookingPanel
            // 
            this.AddSpaBookingPanel.BackColor = System.Drawing.Color.White;
            this.AddSpaBookingPanel.Controls.Add(this.comboBoxCustomers);
            this.AddSpaBookingPanel.Controls.Add(this.label2);
            this.AddSpaBookingPanel.Controls.Add(this.label1);
            this.AddSpaBookingPanel.Controls.Add(this.listViewRooms);
            this.AddSpaBookingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSpaBookingPanel.Location = new System.Drawing.Point(0, 0);
            this.AddSpaBookingPanel.Name = "AddSpaBookingPanel";
            this.AddSpaBookingPanel.Size = new System.Drawing.Size(1153, 607);
            this.AddSpaBookingPanel.TabIndex = 2;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.LargeImageList = this.imageListRooms;
            this.listViewRooms.Location = new System.Drawing.Point(0, 0);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(583, 607);
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
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tạo mới Đặt chỗ Tắm rửa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(593, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn Khách hàng";
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
            this.comboBoxCustomers.Location = new System.Drawing.Point(593, 93);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(548, 36);
            this.comboBoxCustomers.TabIndex = 5;
            // 
            // AddSpaBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 607);
            this.Controls.Add(this.AddSpaBookingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSpaBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSpaBookingForm";
            this.Load += new System.EventHandler(this.AddSpaBookingForm_Load);
            this.AddSpaBookingPanel.ResumeLayout(false);
            this.AddSpaBookingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel AddSpaBookingPanel;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ImageList imageListRooms;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label label2;
    }
}