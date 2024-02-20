using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class AddSpaBookingForm : Form
    {
        private readonly RoomBUS roomBUS;
        private readonly CustomerBUS customerBUS;
        private readonly ServiceBUS serviceBUS;
        private readonly PetBUS petBUS;
        private readonly EmployeeBUS employeeBUS;
        private readonly BookingDetailsBUS bookingDetailsBUS;
        private readonly RoomBookingBUS roomBookingBUS;
        public AddSpaBookingForm()
        {
            InitializeComponent();
            roomBUS = new RoomBUS();
            customerBUS = new CustomerBUS();
            serviceBUS = new ServiceBUS();
            petBUS = new PetBUS();
            employeeBUS = new EmployeeBUS();
            bookingDetailsBUS = new BookingDetailsBUS();
            roomBookingBUS = new RoomBookingBUS();
        }

        private void AddSpaBookingForm_Load(object sender, EventArgs e)
        {
            LoadRooms();
            LoadCustomers();
            LoadServices();
            LoadEmployees();
            LoadTimes();
        }

        private void LoadTimes()
        {
            for (int i = 0; i < 24; i++)
            {
                comboBoxHour.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < 60; i++)
            {
                comboBoxMinute.Items.Add(i.ToString("00"));
            }
        }

        public void LoadRooms()
        {
            List<Rooms> rooms = roomBUS.GetALlRooms();
            foreach (Rooms room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomName);
                item.Tag = room;
                item.SubItems.Add(room.Description);
                if (room.Status == "Available")
                {
                    item.ImageKey = "dog-green.png"; // Phòng có sẵn
                }
                else
                {
                    item.ImageKey = "dog-red.png"; // Phòng không có sẵn
                    item.Selected = false; 
                }
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
            cbxPetList.Items.Add("Select Pet...");
            List<Pets> pets = petBUS.GetPetsByCustomerId(customerId);
            cbxPetList.DisplayMember = "Name";
            cbxPetList.Items.AddRange(pets.ToArray());
            cbxPetList.SelectedIndex = 0;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSelections())
            {
                return;
            }

            var startTime = new TimeSpan(int.Parse(comboBoxHour.SelectedItem.ToString()), int.Parse(comboBoxMinute.SelectedItem.ToString()), 0);
            var selectedRoom = listViewRooms.SelectedItems[0].Tag as Rooms;
            var selectedEmployee = employeeBUS.GetAllEmployees()[comboBoxEmployees.SelectedIndex - 1];
            var selectedService = comboBoxServices.SelectedItem as Service;
            var selectedPet = cbxPetList.SelectedItem as Pets;

            RoomBooking roomBooking = CreateRoomBooking(selectedRoom, selectedPet, selectedEmployee, selectedService, startTime);

            int bookingId = roomBookingBUS.CreateRoomBooking(roomBooking);
            var updateRoomResult = roomBUS.UpdateRoomStatus(selectedRoom.RoomId, "Unavailable");
            var updateEmployeeResult = employeeBUS.UpdateEmployeeStatus(selectedEmployee.EmployeeId, "Busy");
            if (bookingId > 0 && CreateBookingDetails(bookingId, selectedService) && updateRoomResult && updateEmployeeResult)
            {
                MessageBox.Show("Đặt phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi đặt phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateSelections()
        {
            if (listViewRooms.SelectedItems.Count == 0 || comboBoxCustomers.SelectedIndex <= 0 ||
                comboBoxEmployees.SelectedIndex <= 0 || comboBoxServices.SelectedIndex <= 0 || cbxPetList.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin khách hàng, nhân viên và dịch vụ.", "Thông tin cần thiết", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var selectedRoom = listViewRooms.SelectedItems[0].Tag as Rooms;
            if (selectedRoom.Status != "Available")
            {
                MessageBox.Show("Phòng đã chọn không có sẵn. Vui lòng chọn phòng khác.", "Phòng không có sẵn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var selectedEmployeeName = comboBoxEmployees.SelectedItem.ToString();
            if (selectedEmployeeName.StartsWith("BUSY"))
            {
                MessageBox.Show("Nhân viên đã chọn đang bận. Vui lòng chọn nhân viên khác.", "Nhân viên bận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private RoomBooking CreateRoomBooking(Rooms room, Pets pet, Employees employee, Service service, TimeSpan startTime)
        {
            return new RoomBooking
            {
                RoomId = room.RoomId,
                PetId = pet.PetId,
                EmployeeId = employee.EmployeeId,
                Date = dtpDate.Value,
                StartTime = startTime,
                TotalPrice = service.Price,
                TotalDiscount = service.Promotion,
                Status = "Pending",
                PaymentStatus = "Pending"
            };
        }

        private bool CreateBookingDetails(int bookingId, Service service)
        {
            BookingDetails bookingDetails = new BookingDetails
            {
                BookingId = bookingId,
                ServiceId = service.ServiceId,
                Price = service.Price,
                Discount = service.Promotion,
            };

            return bookingDetailsBUS.CreateBookingDetails(bookingDetails);
        }

        private void comboBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomers.SelectedIndex > 0)
            {
                Customers selectedCustomer = comboBoxCustomers.SelectedItem as Customers;
                if (selectedCustomer != null)
                {
                    lblCustomerName.Text = selectedCustomer.Name;
                    lblPhoneNumber.Text = selectedCustomer.PhoneNumber;
                    lblUserEmail.Text = selectedCustomer.Email;
                    LoadPets(selectedCustomer.CustomerId);
                }

                panelBooking.Visible = true;
                panelChooseCustomer.Visible = false;
            }
            else
            {
                
                panelBooking.Visible = false;
            }
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxServices.SelectedItem is Service selectedService)
            {
                lblPrice.Text = selectedService.Price.ToString() + "đ";
            }
        }

        private void lblDeleteChoose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelBooking.Visible = false;
            panelChooseCustomer.Visible = true;
            comboBoxCustomers.SelectedIndex = 0;
        }
    }
}
