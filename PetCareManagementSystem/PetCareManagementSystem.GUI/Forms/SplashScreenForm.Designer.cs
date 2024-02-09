namespace PetCareManagementSystem.GUI.Forms
{
    partial class SplashScreenForm
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
            this.progressBarLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.AutoRoundedCorners = true;
            this.progressBarLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.progressBarLoading.BorderRadius = 16;
            this.progressBarLoading.FillColor = System.Drawing.Color.White;
            this.progressBarLoading.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLoading.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.progressBarLoading.Location = new System.Drawing.Point(293, 441);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.ProgressColor = System.Drawing.Color.Fuchsia;
            this.progressBarLoading.ProgressColor2 = System.Drawing.Color.Cyan;
            this.progressBarLoading.ShowText = true;
            this.progressBarLoading.Size = new System.Drawing.Size(446, 34);
            this.progressBarLoading.TabIndex = 1;
            this.progressBarLoading.Text = "guna2ProgressBar1";
            this.progressBarLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Interval = 800;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PetCareManagementSystem.GUI.Properties.Resources.plash_screen;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(993, 504);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(451, 298);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(98, 22);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "pet shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 503);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer timerSplashScreen;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
    }
}