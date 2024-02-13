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
    public partial class AddProForm : Form
    {
        public AddProForm()
        {
            InitializeComponent();
            cateProBus = new CateProBUS();
            SupllierBus = new SupplierBUS();
            receiptBus = new ReceiptBUS();
            receiptDetailBus = new ReceiptDetailBUS();
            productBus = new ProductBUS();
        }
        private CategoryProduct selectedCate;
        private CateProBUS cateProBus;

        private SupplierBUS SupllierBus;
        private ReceiptBUS receiptBus;
        private ReceiptDetailBUS receiptDetailBus;
        private ProductBUS productBus;
        private void cbCatePro_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCate = (CategoryProduct)cbCatePro.SelectedItem;
        }

        private void AddProForm_Load(object sender, EventArgs e)
        {

            listView1.View = View.Details;


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
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            string NameProduct = txtNameProduct.Text;

            string selectedCategoty = (selectedCate != null) ? selectedCate.CateProName : "N/A";

            string UnitPrice = txtUnitPrice.Text;
            string Description = txtDescription.Text;

            if (NameProduct == "" || UnitPrice == "" || selectedCategoty == "N/A")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int categoryId = selectedCate.CateProId;

                ListViewItem newItem = new ListViewItem(new string[] { NameProduct, selectedCategoty, Description, UnitPrice, categoryId.ToString() });
                listView1.Items.Add(newItem);
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            txtNameProduct.Clear();
            cbCatePro.SelectedItem = null;
            txtDescription.Clear();
            txtUnitPrice.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtNameProduct.Text == "" || cbCatePro.Text == "" || txtDescription.Text == "N/A" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[0].Text = txtNameProduct.Text;
                selectedItem.SubItems[1].Text = cbCatePro.Text;
                selectedItem.SubItems[2].Text = txtDescription.Text;
                selectedItem.SubItems[3].Text = txtUnitPrice.Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa các mục đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Nếu người dùng chọn Yes
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in listView1.SelectedItems.Cast<ListViewItem>().ToList())
                    {
                        listView1.Items.Remove(item);
                        ClearTextBoxes();
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtNameProduct.Text = selectedItem.SubItems[0].Text;
                cbCatePro.Text = selectedItem.SubItems[1].Text;
                txtDescription.Text = selectedItem.SubItems[2].Text;
                txtUnitPrice.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string NameProduct;
                int CategoryPro;

                int UnitPrice;

                string Description;
                foreach (ListViewItem item in listView1.Items)
                {
                    NameProduct = item.SubItems[0].Text;
                    Description = item.SubItems[2].Text;
                    UnitPrice = int.Parse(item.SubItems[3].Text);

                    CategoryPro = int.Parse(item.SubItems[4].Text);


                    bool saveProduct = productBus.AddProduct(CategoryPro, NameProduct, Description, UnitPrice);

                    if (saveProduct)
                    {
                        MessageBox.Show("Lưu thành công");
                        listView1.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}
