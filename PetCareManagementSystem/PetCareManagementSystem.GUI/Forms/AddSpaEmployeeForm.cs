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
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class AddSpaEmployeeForm : Form
    {
        private readonly RoleBUS roleBUS;
        private readonly EmployeeBUS employeeBUS;
        private readonly EmployeeRoleBUS employeeRoleBUS;
        public AddSpaEmployeeForm()
        {
            InitializeComponent();
            roleBUS = new RoleBUS();
            employeeBUS = new EmployeeBUS();
            employeeRoleBUS = new EmployeeRoleBUS();
        }

        private void AddSpaEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private void LoadRole()
        {
            List<DTO.Models.Roles> rolesList = roleBUS.GetAll();
            cboRole.DataSource = rolesList;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleId";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtPhoneNumber.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if (txtPhoneNumber.Text.Length != 10 || !txtPhoneNumber.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có 10 ký tự.");
                txtPhoneNumber.Focus();
                return;
            }

            if (cboAddressCenter.SelectedIndex < 0) 
            {
                MessageBox.Show("Vui lòng chọn Trung tâm Chăm sóc Thú cưng.");
                cboAddressCenter.Focus();
                return;
            }

            bool emailExists = employeeBUS.EmailExists(txtEmail.Text);
            if (emailExists)
            {
                MessageBox.Show("Email đã được sử dụng. Vui lòng sử dụng email khác.");
                txtEmail.Focus();
                return;
            }

            var newEmployee = new Employees
            {
                Name = txtFirstName.Text + " " + txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Password = txtPassword.Text,
                ImageUrl = null,
                Status = tsStatus.Checked ? "Available" : "Busy",
                Address = txtAddress.Text,

            };


            bool isEmployeeAdded = employeeBUS.AddEmployee(newEmployee);
            if (isEmployeeAdded)
            {
                int newEmployeeId = employeeBUS.GetLastInsertedId(); 

                var employeeRole = new EmployeeRoles
                {
                    EmployeeID = newEmployeeId,
                    RoleID = (int)cboRole.SelectedValue
                };

                bool isRoleAdded = employeeRoleBUS.AddEmployeeRole(employeeRole);
                if (isRoleAdded)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công.");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm vai trò cho nhân viên mới.");
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên mới.");
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
