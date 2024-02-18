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
        private RoomBUS roomBUS;
        private CustomerBUS customerBUS;
        public AddSpaBookingForm()
        {
            InitializeComponent();
            roomBUS = new RoomBUS();
            customerBUS = new CustomerBUS();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSpaBookingForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadCustomers();
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
            comboBoxCustomers.Items.Add("Select Customer...");
            comboBoxCustomers.SelectedIndex = 0;

            List<Customers> customers = customerBUS.GetAll();
            foreach (Customers customer in customers)
            {
                comboBoxCustomers.Items.Add(customer.Name);
                comboBoxCustomers.Tag = customer.CustomerId; 
            }
        }
    }
}
