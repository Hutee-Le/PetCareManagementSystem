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
    public partial class ManageSpaEmployeesForm : Form
    {
        private EmployeeBUS employeeBUS => new EmployeeBUS();
        public ManageSpaEmployeesForm()
        {
            InitializeComponent();
        }

        private void ManageSpaEmployeesForm_Load(object sender, EventArgs e)
        {
            dataGridViewSpaEmployees.AutoGenerateColumns = false;
            dataGridViewSpaEmployees.DataSource = employeeBUS.GetSpaEmployeeDetails();
            
        }
    }
}
