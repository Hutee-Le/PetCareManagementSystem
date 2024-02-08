using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using PetCareManagementSystem.GUI.Forms;
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
        #region Fields

        private EmployeeBUS employeeBUS;

        #endregion

        #region Constructors

        public LoginForm()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
        }

        #endregion

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
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
                        this.Hide();
                        SplashScreenForm splashScreenForm = new SplashScreenForm();
                        splashScreenForm.ShowDialog();

                        MainForm mainForm = new MainForm(loggedInUser,this);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion
    }
}
