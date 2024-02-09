namespace PetCareManagementSystem.GUI.Forms
{
    partial class DashboardForm
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
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.DashboardTabPanel = new PetCareManagementSystem.GUI.CustomControls.RoundedPanel();
            this.DashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.DashboardPanel.Controls.Add(this.DashboardTabPanel);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(1095, 450);
            this.DashboardPanel.TabIndex = 0;
            // 
            // DashboardTabPanel
            // 
            this.DashboardTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardTabPanel.BackColor = System.Drawing.Color.White;
            this.DashboardTabPanel.Location = new System.Drawing.Point(12, 25);
            this.DashboardTabPanel.Name = "DashboardTabPanel";
            this.DashboardTabPanel.Radius = 5;
            this.DashboardTabPanel.Size = new System.Drawing.Size(1071, 47);
            this.DashboardTabPanel.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.DashboardPanel);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.DashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private CustomControls.RoundedPanel DashboardTabPanel;
    }
}