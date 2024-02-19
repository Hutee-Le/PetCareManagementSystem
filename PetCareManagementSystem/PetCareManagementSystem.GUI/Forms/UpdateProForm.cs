using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class UpdateProForm : Form
    {
        public UpdateProForm(Product pro)
        {
            InitializeComponent();
            this.pro = pro;
            cateProBus = new CateProBUS();
            productBus = new ProductBUS();
        }
        private Product pro;
        private CategoryProduct selectedCate;
        private CateProBUS cateProBus;

        private SupplierBUS SupllierBus;
        private ReceiptBUS receiptBus;
        private ReceiptDetailBUS receiptDetailBus;
        private ProductBUS productBus;
        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProForm_Load(object sender, EventArgs e)
        {

            var categories = cateProBus.getAll();


            CategoryProduct initialCategory = new CategoryProduct
            {
                CateProId = -1,
                CateProName = "Loại sản phẩm"
            };
            categories.Insert(0, initialCategory);
            cbCatePro.DataSource = categories;
            cbCatePro.DisplayMember = "CateProName";
            cbCatePro.ValueMember = "CateProId";
            cbCatePro.SelectedIndex = 0;
            txtNameProduct.Text = pro.ProductName;

            

            txtDescription.Text = pro.Description;

            // Chuyển đổi UnitPrice từ decimal sang string
            txtUnitPrice.Text = pro.UnitPrice.ToString();
            string categoryName = cateProBus.GetNameCateById(pro.CateProId);

            // Hiển thị tên loại sản phẩm trong cbCatePro.Text
            cbCatePro.Text = categoryName;
        }
    }
}
