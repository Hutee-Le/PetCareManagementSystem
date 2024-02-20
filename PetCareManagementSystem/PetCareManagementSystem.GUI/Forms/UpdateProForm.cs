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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string NameProduct;
            int CategoryPro;
            decimal UnitPrice;
            int ProductId = productBus.getProductIDbyName(pro.ProductName);
            string Description;

            if (txtNameProduct.Text == "" || cbCatePro.Text == "" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (decimal.TryParse(txtUnitPrice.Text, out UnitPrice))
                {
                    NameProduct = txtNameProduct.Text;
                    Description = txtDescription.Text;
                   

                    CategoryPro = cateProBus.getCateIDbyName(cbCatePro.Text);
                    bool saveProduct = productBus.UpdateProduct(ProductId,CategoryPro, NameProduct, Description, UnitPrice);

                    if (saveProduct)
                    {
                        MessageBox.Show("Update sản phẩm thành công");
                        DialogResult result = MessageBox.Show("Bạn muốn tiếp tục sửa sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        // Nếu người dùng chọn Yes
                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Update sản phẩm thất bại");
                    }


                }
                else
                {
                    // Parsing failed, show error message or handle the situation accordingly
                    MessageBox.Show("Giá sản phẩm không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát và không lưu các thay đổi?", "Đồng ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Nếu người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
