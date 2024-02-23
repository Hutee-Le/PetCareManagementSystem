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
    public partial class AddNewCustomerForm : Form
    {
        private readonly CustomerBUS customerBUS;
        public AddNewCustomerForm()
        {
            InitializeComponent();
            customerBUS = new CustomerBUS();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên.");
                txtLastName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ.");
                txtFirstName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.");
                txtEmail.Focus();
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.");
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                txtPhoneNumber.Focus();
                return;
            }
            if (txtPhoneNumber.Text.Length != 10 || !txtPhoneNumber.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có 10 ký tự.");
                txtPhoneNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txtConfirmPassword.Focus();
                return;
            }


            if(!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pnlGender.Focus();
                return;
            }

            bool emailExists = customerBUS.EmailExists(txtEmail.Text);
            if (emailExists)
            {
                MessageBox.Show("Email đã được sử dụng. Vui lòng sử dụng email khác.");
                txtEmail.Focus();
                return;
            }

            var newCustomer = new Customers
            {
                Name = txtFirstName.Text + " " + txtLastName.Text,
                CustomerTypeId = 1,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Password = txtPassword.Text,
                ImageUrl = null,
                Address = txtAddress.Text,
                Gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : null,
                UpdateTime = DateTime.Now
            };

            bool isCustomerAdded = customerBUS.AddCustomer(newCustomer);
            if (isCustomerAdded)
            {
                MessageBox.Show("Khách hàng mới đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình thêm khách hàng mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
