﻿using Microsoft.Extensions.Configuration;
using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class ManageReceiptForm : Form
    {
        public ManageReceiptForm(Employees employees, LoginForm loginForm)
        {
            InitializeComponent();
            cateProBus = new CateProBUS();
            SuplierBus = new SupplierBUS();
            receiptBus = new ReceiptBUS();
            receiptDetailBus = new ReceiptDetailBUS();
            productBus = new ProductBUS();
            _employees = employees;
            _loginForm = loginForm;
        }

        private CateProBUS cateProBus;
        private LoginForm _loginForm;
        private SupplierBUS SuplierBus;
        private ReceiptBUS receiptBus;
        private ReceiptDetailBUS receiptDetailBus;
        private ProductBUS productBus;
        private Employees _employees;
        private CategoryProduct selectedCate;
        private Suppliers selectedSup;


        private void listViewPro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewPro.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPro.SelectedItems[0];
                txtNameProduct.Text = selectedItem.SubItems[1].Text;
                //cbCatePro.Text = selectedItem.SubItems[1].Text;
                //txtDescription.Text = selectedItem.SubItems[2].Text;
                txtUnitPrice.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void cbCatePro_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewPro.Items.Clear();
            if (cbCatePro.SelectedIndex != -1)
            {
                selectedCate = (CategoryProduct)cbCatePro.SelectedItem;
                int categoryId = selectedCate.CateProId;
                // Lấy loại được chọn từ ComboBox
                string selectedCategory = cbCatePro.SelectedItem.ToString();

                // Kiểm tra xem loại đã chọn có tồn tại trong danh sách không
                //if (cbCatePro.Items.Contains(selectedCategory))
                //{
                List<Product> listproduct = productBus.GetProByCateId(categoryId);

                foreach (Product product in listproduct)
                {
                    ListViewItem item = new ListViewItem(product.ProductId.ToString());
                    item.SubItems.Add(product.ProductName.ToString());
                    item.SubItems.Add(product.UnitPrice.ToString());
                    listViewPro.Items.Add(item);
                }
            }
            else
            {

            }
        }
        private decimal CalculateSumPrice()
        {

            if (decimal.TryParse(nmcNumber.Text, out decimal count) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                decimal sumPrice = count * unitPrice;
                txtSumPrice.Text = sumPrice.ToString();
                return sumPrice;
            }
            return 0;
        }
        int employeeID = 1;
        private void ClearTextBoxes()
        {
            txtNameProduct.Clear();
            cbCatePro.SelectedItem = null;
            cbSup.SelectedItem = null;
            nmcNumber.Value = 0;
            txtUnitPrice.Clear();

            txtSumPrice.Clear();
        }
        private decimal nmcValue;
        private void cbSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSup = (Suppliers)cbSup.SelectedItem;
        }

        private void txtSumPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSumPrice();
        }

        private void nmcNumber_ValueChanged(object sender, EventArgs e)
        {
            CalculateSumPrice();
            nmcValue = (decimal)nmcNumber.Value;
        }

        private void ManageReceiptForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listViewPro.View = View.Details;
            listVreceiptDetail.View = View.Details;

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

            var supplier = SuplierBus.getAll();

            Suppliers suppliers = new Suppliers()
            {
                SupplierId = -1,
                SupplierName = "Nhà cung cấp"
            };
            supplier.Insert(0, suppliers);

            cbSup.DataSource = supplier;
            cbSup.DisplayMember = "SupplierName";
            cbSup.ValueMember = "SupplierID";
            cbSup.SelectedIndex = 0;
            listvReceipt.View = View.Details;
            List<Receipt> receipt = receiptBus.getAll();
            int count = 0;

            foreach (Receipt rec in receipt)
            {
                ListViewItem item = new ListViewItem(rec.ReceiptId.ToString());
                
                string Employeename = receiptBus.GetEmployeenameByID(rec.EmployeeId);
                item.SubItems.Add(Employeename);
                item.SubItems.Add(rec.TotalAmount.ToString());
                item.SubItems.Add(rec.ReceiptDate.ToString());

                listvReceipt.Items.Add(item);
                //  txtClass.Text = node.Tag.ToString();

                count++;
            }
            List<ReceiptDetail> receiptdetail = receiptDetailBus.getAll();
          
            foreach (ReceiptDetail rec in receiptdetail)
            {
                ListViewItem item = new ListViewItem(rec.ReceiptDetailId.ToString());

                string Supname = SuplierBus.GetSupnameByID(rec.SupplierId);
                item.SubItems.Add(Supname);
              
                string Proname = productBus.getProNamebyID(rec.ProductId);
                item.SubItems.Add(Proname);
                item.SubItems.Add(rec.Quantity.ToString());
                item.SubItems.Add(rec.UnitPrice.ToString());
                item.SubItems.Add(rec.TotalPricePro.ToString());
                listVreceiptDetail.Items.Add(item);
                //  txtClass.Text = node.Tag.ToString();

            }

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            string NameProduct = txtNameProduct.Text;
            string selectedSupplier = (selectedSup != null) ? selectedSup.SupplierName : "-1";
            string selectedCategory = (selectedCate != null) ? selectedCate.CateProName : "-1";
            nmcValue = (decimal)nmcNumber.Value;
            string UnitPrice = txtUnitPrice.Text;
            string SumPrice = CalculateSumPrice().ToString();
            txtSumPrice.Text = SumPrice;

            DateTime DateInput = DateTime.Now;

            string selectedCount = (nmcValue != null) ? nmcValue.ToString() : "0";

            if (NameProduct == "" || selectedCount == "0" || UnitPrice == "" || SumPrice == "" || selectedCategory == "-1" || selectedSupplier == "-1")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                int categoryId = (selectedCate != null) ? selectedCate.CateProId : -1;
                int supplierId = (selectedSup != null) ? selectedSup.SupplierId : -1;

                int product = productBus.getProductIDbyName(NameProduct);

                if (categoryId != -1 && supplierId != -1)
                {
                    ListViewItem newItem = new ListViewItem(new string[] { NameProduct, selectedCategory, selectedSupplier, UnitPrice, selectedCount, SumPrice, categoryId.ToString(), supplierId.ToString(), product.ToString() });
                    listView1.Items.Add(newItem);
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Không thể thêm mục với các giá trị chưa được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //int SupId = selectedSup.SupplierId;
            string selectedSupplier = (selectedSup != null) ? selectedSup.SupplierName : "-1";
            string selectedCategory = (selectedCate != null) ? selectedCate.CateProName : "-1";
            if (txtNameProduct.Text == "" || cbCatePro.Text == "-1" || cbSup.Text == "-1" || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                selectedItem.SubItems[0].Text = txtNameProduct.Text;
                selectedItem.SubItems[1].Text = cbCatePro.Text;
                selectedItem.SubItems[2].Text = cbSup.Text;
                selectedItem.SubItems[3].Text = txtUnitPrice.Text;
                selectedItem.SubItems[4].Text = nmcNumber.Value.ToString();
                string SumPrice = CalculateSumPrice().ToString();
                selectedItem.SubItems[5].Text = SumPrice;
                int categoryId = selectedCate.CateProId;
                int SupId = selectedSup.SupplierId;
                selectedItem.SubItems[6].Text = categoryId.ToString();
                selectedItem.SubItems[7].Text = SupId.ToString();
                ClearTextBoxes();
                btnAddnew.Enabled = true;
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
                        btnAddnew.Enabled = true;
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime DateInput = DateTime.Now;

                decimal totalAmount = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    totalAmount += decimal.Parse(item.SubItems[5].Text);
                }


                int receiptID = receiptBus.AddReceipt(_employees.EmployeeId, DateInput, totalAmount);
                if (receiptID != -1)
                {
                    MessageBox.Show("Lưu thành công phiếu nhập kho");

                    int ProductID;

                    int Quantity;

                    int SupplierPro;
                    decimal UnitPrice;
                    int testUnit;
                    decimal TotalPricePro;


                    foreach (ListViewItem item in listView1.Items)
                    {
                        int ReceiptID = receiptBus.getIDReceipt();
                        UnitPrice = decimal.Parse(item.SubItems[3].Text);
                        Quantity = int.Parse(item.SubItems[4].Text);
                        TotalPricePro = decimal.Parse(item.SubItems[5].Text);

                        SupplierPro = int.Parse(item.SubItems[7].Text);

                        ProductID = int.Parse(item.SubItems[8].Text);

                        // Gọi phương thức AddProduct để lưu sản phẩm vào cơ sở dữ liệu
                        bool saveReceiptDetail = receiptDetailBus.AddReceiptDetail(ReceiptID, SupplierPro, ProductID, Quantity, UnitPrice, TotalPricePro);

                        if (saveReceiptDetail)
                        {
                            MessageBox.Show("Lưu chi tiết phiếu nhập kho thành công");
                            listView1.Items.Clear();
                            LoadListViewData();
                        }
                        else
                        {
                            MessageBox.Show("Lưu thất bại chi tiết phiếu nhập kho thất bại");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu phiếu nhập hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            AddProForm addpro = new AddProForm();
            addpro.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtNameProduct.Text = selectedItem.SubItems[0].Text;
                cbCatePro.Text = selectedItem.SubItems[1].Text;
                cbSup.Text = selectedItem.SubItems[2].Text;
                txtUnitPrice.Text = selectedItem.SubItems[3].Text;

                decimal numberValue;
                if (Decimal.TryParse(selectedItem.SubItems[4].Text, out numberValue))
                {
                    nmcNumber.Value = numberValue;
                }
                else
                {
                    // Handle parsing failure, maybe show an error message or set a default value
                }


                txtSumPrice.Text = selectedItem.SubItems[5].Text;
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listvReceipt.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listvReceipt.SelectedItems[0];
                string selectedText = selectedItem.SubItems[0].Text;
                if (int.TryParse(selectedText, out int selectedReceipt))
                {
                    //ReceiptDetail receiptDetail = receiptDetailBus.GetRecDetailByReceiptId(selectedReceipt);
                    //ManageRecDetailForm viewredetail = new ManageRecDetailForm(receiptDetail);
                    //viewredetail.ShowDialog();
                    listVreceiptDetail.View = View.Details;
                    listVreceiptDetail.Items.Clear();
                    List<ReceiptDetail> receiptdetail = receiptDetailBus.GetRecDetailByReceiptId(selectedReceipt);
                    int count = 0;

                    foreach (ReceiptDetail recd in receiptdetail)
                    {
                        ListViewItem item = new ListViewItem(recd.ReceiptDetailId.ToString());

                        //string Employeename = receiptBus.GetEmployeenameByID(recd.EmployeeId);
                        //item.SubItems.Add(Employeename);

                        item.SubItems.Add(recd.SupplierId.ToString());
                        item.SubItems.Add(recd.ProductId.ToString());
                        item.SubItems.Add(recd.Quantity.ToString());
                        item.SubItems.Add(recd.UnitPrice.ToString());
                        item.SubItems.Add(recd.TotalPricePro.ToString());

                        listVreceiptDetail.Items.Add(item);
                     
                        count++;
                    }

                }

            }
        }

        private void listReceiptDetail_Load(object sender, EventArgs e)
        { 

        }

            private void LoadListViewData()
        {
            listvReceipt.Items.Clear();
            List<Receipt> receipt = receiptBus.getAll();
            int count = 0;

            foreach (Receipt rec in receipt)
            {
                ListViewItem item = new ListViewItem(rec.ReceiptId.ToString());

                string Employeename = receiptBus.GetEmployeenameByID(rec.EmployeeId);
                item.SubItems.Add(Employeename);
                item.SubItems.Add(rec.TotalAmount.ToString());
                item.SubItems.Add(rec.ReceiptDate.ToString());

                listvReceipt.Items.Add(item);
             
                count++;
            }
           
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            listVreceiptDetail.Items.Clear();
            List<ReceiptDetail> receiptdetail = receiptDetailBus.getAll();

            foreach (ReceiptDetail rec in receiptdetail)
            {
                ListViewItem item = new ListViewItem(rec.ReceiptDetailId.ToString());

                string Supname = SuplierBus.GetSupnameByID(rec.SupplierId);
                item.SubItems.Add(Supname);

                string Proname = productBus.getProNamebyID(rec.ProductId);
                item.SubItems.Add(Proname);
                item.SubItems.Add(rec.Quantity.ToString());
                item.SubItems.Add(rec.UnitPrice.ToString());
                item.SubItems.Add(rec.TotalPricePro.ToString());
                listVreceiptDetail.Items.Add(item);
                //  txtClass.Text = node.Tag.ToString();

            }
        }
    }
}
