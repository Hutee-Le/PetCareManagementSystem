using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class ManageCustomPetForm : Form
    {
        public readonly CustomerBUS customerBUS;
        public readonly PetBUS petBUS;
        public ManageCustomPetForm()
        {
            InitializeComponent();
            customerBUS = new CustomerBUS();
            petBUS = new PetBUS();
        }

        private void ManageCustomPetForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            DataTable dt = customerBUS.GetCustomPetDetails();
            dt.Columns.Add("Image", typeof(Image));
            foreach (DataRow row in dt.Rows)
            {
                string imageUrl = row["ImageUrl"].ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    Image image = (Image)Properties.Resources.ResourceManager.GetObject(imageUrl);
                    row["Image"] = image;
                }
                else
                {
                    row["Image"] = Properties.Resources.default_avatar;
                }
            }
            dataGridViewCustomerPet.AutoGenerateColumns = false;
            dataGridViewCustomerPet.DataSource = dt;
        }

        private void AddNewSpaBooking_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();
            addNewCustomerForm.FormClosed += AddNewCustomer_FormClosed;
            addNewCustomerForm.MdiParent = this.MdiParent;
            addNewCustomerForm.FormBorderStyle = FormBorderStyle.None;
            addNewCustomerForm.Dock = DockStyle.Right;
            addNewCustomerForm.Show();
        }

        private void AddNewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomers();
        }

        private void dataGridViewCustomerPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int customerId = Convert.ToInt32(dataGridViewCustomerPet["CustomerID", e.RowIndex].Value);

            if (e.ColumnIndex == dataGridViewCustomerPet.Columns["addButtonColumn"].Index && e.RowIndex >= 0)
            {
                AddNewPetForm addNewPet = new AddNewPetForm(customerId);
                addNewPet.FormClosed += AddNewPet_FormClosed;
                addNewPet.MdiParent = this.MdiParent;
                addNewPet.FormBorderStyle = FormBorderStyle.None;
                addNewPet.Dock = DockStyle.Right;
                addNewPet.Show();
            }

            if (e.ColumnIndex == dataGridViewCustomerPet.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool successDeletePets = petBUS.DeletePetByCustomerId(customerId);

                    if (successDeletePets)
                    {
                        bool successDeleteCustomer = customerBUS.DeleteCustomer(customerId);

                        if (successDeleteCustomer)
                        {
                            MessageBox.Show("Xóa khách hàng và thú cưng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers(); // Tải lại danh sách khách hàng
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa thú cưng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddNewPet_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadCustomers();
        }
    }
}
