namespace PetCareManagementSystem.GUI.Forms
{
    partial class ManageProForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddPro = new Guna.UI2.WinForms.Guna2Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.actDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavbarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.NavbarHeader.Size = new System.Drawing.Size(1368, 82);
            this.NavbarHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(987, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameProduct,
            this.Category,
            this.UnitPrice,
            this.Quantity,
            this.actEdit,
            this.actDelete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1368, 455);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Animated = true;
            this.btnAddPro.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.btnAddPro.BorderRadius = 10;
            this.btnAddPro.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.btnAddPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(218)))));
            this.btnAddPro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddPro.ForeColor = System.Drawing.Color.White;
            this.btnAddPro.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPro.Location = new System.Drawing.Point(1133, 87);
            this.btnAddPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(111, 46);
            this.btnAddPro.TabIndex = 107;
            this.btnAddPro.Text = "Add Product";
            this.btnAddPro.UseTransparentBackground = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProductID";
            this.ID.FillWeight = 1F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 6;
            // 
            // NameProduct
            // 
            this.NameProduct.DataPropertyName = "ProductName";
            this.NameProduct.HeaderText = "Tên sản phẩm";
            this.NameProduct.MinimumWidth = 6;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CateProID";
            this.Category.HeaderText = "Loại sản phẩm";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QuantityInStock";
            this.Quantity.HeaderText = "Số Lượng Tồn Kho";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // actEdit
            // 
            this.actEdit.HeaderText = "Action";
            this.actEdit.MinimumWidth = 6;
            this.actEdit.Name = "actEdit";
            this.actEdit.Text = "Edit";
            this.actEdit.ToolTipText = "Edit";
            this.actEdit.UseColumnTextForButtonValue = true;
            this.actEdit.Width = 125;
            // 
            // actDelete
            // 
            this.actDelete.HeaderText = "Action";
            this.actDelete.MinimumWidth = 6;
            this.actDelete.Name = "actDelete";
            this.actDelete.Text = "Delete";
            this.actDelete.UseColumnTextForButtonValue = true;
            this.actDelete.Width = 125;
            // 
            // ManageProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 655);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NavbarHeader);
            this.Name = "ManageProForm";
            this.Text = "ManageProForm";
            this.Load += new System.EventHandler(this.ManageProForm_Load);
            this.NavbarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel NavbarHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnAddPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn actEdit;
        private System.Windows.Forms.DataGridViewButtonColumn actDelete;
    }
}