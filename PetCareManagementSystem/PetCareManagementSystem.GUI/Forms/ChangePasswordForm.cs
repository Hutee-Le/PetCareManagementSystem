using PetCareManagementSystem.BLL;
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
    public partial class ChangePasswordForm : Form
    {
        private readonly EmployeeBUS employeeBUS;
        private int _employeeId;
        public ChangePasswordForm(int employeeId)
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            _employeeId = employeeId;
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


            bool isChanged = employeeBUS.ChangePassword(_employeeId, txtPassword.Text);
            if (isChanged)
            {
                MessageBox.Show("Mật khẩu đã được cập nhật thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật mật khẩu.");
           }  
        }
    }
}
