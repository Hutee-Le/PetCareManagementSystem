namespace PetCareManagementSystem.GUI.Forms
{
    partial class BookingManagementForm
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
            this.NavbarHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NavbarHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarHeader
            // 
            this.NavbarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.NavbarHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavbarHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(93)))), ((int)(((byte)(238)))));
            this.NavbarHeader.BorderRadius = 10;
            this.NavbarHeader.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.NavbarHeader.Controls.Add(this.label1);
            this.NavbarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarHeader.Location = new System.Drawing.Point(0, 0);
            this.NavbarHeader.Name = "NavbarHeader";
            this.NavbarHeader.Size = new System.Drawing.Size(1171, 100);
            this.NavbarHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1093, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn đặt spa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.NavbarHeader);
            this.Name = "BookingManagementForm";
            this.Text = "BookingManagementForm";
            this.NavbarHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel NavbarHeader;
        private System.Windows.Forms.Label label1;
    }
}