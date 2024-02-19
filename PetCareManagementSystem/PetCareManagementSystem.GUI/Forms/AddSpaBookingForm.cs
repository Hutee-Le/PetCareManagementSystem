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
    public partial class AddSpaBookingForm : Form
    {
        private readonly RoomBUS roomBUS;
        private readonly CustomerBUS customerBUS;
        private readonly ServiceBUS serviceBUS;
        private readonly PetBUS petBUS;
        private readonly EmployeeBUS employeeBUS;
        public AddSpaBookingForm()
        {
            InitializeComponent();
            roomBUS = new RoomBUS();
            customerBUS = new CustomerBUS();
            serviceBUS = new ServiceBUS();
            petBUS = new PetBUS();
            employeeBUS = new EmployeeBUS();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSpaBookingForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadCustomers();
            LoadServices();
            LoadEmployees();
        }

        public void LoadRooms()
        {
            List<Rooms> rooms = roomBUS.GetALlRooms();
            foreach (Rooms room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomName);
                item.Tag = room.RoomId;
                item.SubItems.Add(room.Description);
                item.ImageKey = room.Status == "Available" ? "dog-green.png" : "dog-red.png";
                listViewRooms.Items.Add(item);
            }
        }

        public void LoadCustomers()
        {
            comboBoxCustomers.Items.Clear();
            comboBoxCustomers.Items.Add("Select Customer...");
            List<Customers> customers = customerBUS.GetAll();
            comboBoxCustomers.DisplayMember = "Name";
            comboBoxCustomers.Items.AddRange(customers.ToArray());
            comboBoxCustomers.SelectedIndex = 0;
        }

        private void LoadEmployees()
        {
            comboBoxEmployees.Items.Clear();
            comboBoxEmployees.Items.Add("Select Employee...");
            List<Employees> employees = employeeBUS.GetAllEmployees();
            comboBoxEmployees.DisplayMember = "Name";
            foreach (Employees employee in employees)
            {
                string status = employee.Status == "Busy" ? "BUSY: " : "";
                comboBoxEmployees.Items.Add($"{status}{employee.Name}");
            }
            comboBoxEmployees.SelectedIndex = 0;
        }


        private void LoadPets(int customerId)
        {
            cbxPetList.Items.Clear();
            List<Pets> pets = petBUS.GetPetsByCustomerId(customerId);
            cbxPetList.DisplayMember = "Name";
            cbxPetList.Items.AddRange(pets.ToArray());
        }

        private void LoadServices()
        {
            comboBoxServices.Items.Clear();
            comboBoxServices.Items.Add("Select Service...");
            List<Service> services = serviceBUS.GetServicesByTypeName("DV Spa Pet");
            comboBoxServices.DisplayMember = "ServiceName";
            comboBoxServices.Items.AddRange(services.ToArray());
            comboBoxServices.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomers.SelectedItem is Customers selectedCustomer)
            {
                lblCustomerName.Text = selectedCustomer.Name;
                lblPhoneNumber.Text = selectedCustomer.PhoneNumber;
                lblUserEmail.Text = selectedCustomer.Email;
                LoadPets(selectedCustomer.CustomerId);
            }
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxServices.SelectedItem is Service selectedService)
            {
                lblPrice.Text = selectedService.Price.ToString() + "đ";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
