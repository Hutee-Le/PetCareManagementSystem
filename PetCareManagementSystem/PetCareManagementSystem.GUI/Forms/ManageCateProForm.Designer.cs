namespace PetCareManagementSystem.GUI.Forms
{
    partial class ManageCateProForm
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
            System.Windows.Forms.ColumnHeader columnHeader2;
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeViewCate = new System.Windows.Forms.TreeView();
            this.NavbarHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NavbarHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvProduct
            // 
            this.lsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.HideSelection = false;
            this.lsvProduct.Location = new System.Drawing.Point(384, 184);
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(745, 372);
            this.lsvProduct.TabIndex = 7;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.SelectedIndexChanged += new System.EventHandler(this.lsvProduct_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Product";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Sản phẩm";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng tồn kho";
            // 
            // treeViewCate
            // 
            this.treeViewCate.Location = new System.Drawing.Point(21, 184);
            this.treeViewCate.Name = "treeViewCate";
            this.treeViewCate.Size = new System.Drawing.Size(344, 372);
            this.treeViewCate.TabIndex = 6;
            this.treeViewCate.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCate_AfterSelect);
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
            this.NavbarHeader.Size = new System.Drawing.Size(1230, 100);
            this.NavbarHeader.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(987, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Danh mục Sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageCateProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 634);
            this.Controls.Add(this.lsvProduct);
            this.Controls.Add(this.treeViewCate);
            this.Controls.Add(this.NavbarHeader);
            this.Name = "ManageCateProForm";
            this.Text = "ManageCateProForm";
            this.Load += new System.EventHandler(this.ManageCateProForm_Load);
            this.NavbarHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TreeView treeViewCate;
        private Guna.UI2.WinForms.Guna2Panel NavbarHeader;
        private System.Windows.Forms.Label label1;
    }
}