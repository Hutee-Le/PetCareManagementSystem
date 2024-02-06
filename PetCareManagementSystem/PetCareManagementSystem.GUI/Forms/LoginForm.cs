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

namespace PetCareManagementSystem.GUI
{
    public partial class LoginForm : Form
    {
        private EmployeeBUS employeeBUS;
        public LoginForm()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool isAuthenticated = employeeBUS.AuthenticateUser(email, password);
            if (isAuthenticated)
            {
                Employees loggedInUser = employeeBUS.GetEmployeeByEmail(email);
                if (loggedInUser != null)
                {
                    if (!toggleRemember.Checked)
                    {
                        txtEmail.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }
                    // Ẩn form đăng nhập
                    this.Hide();

                    MainForm mainForm = new MainForm(loggedInUser);
                    mainForm.Show();
                }
                else
                {
                    // Trường hợp không tìm thấy người dùng
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Authentication failed, show error message
                MessageBox.Show("Invalid email or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowLoginForm()
        {
            // Hiển thị lại LoginForm
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
