using PetCareManagementSystem.BLL;
using PetCareManagementSystem.DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class SpaBookingForm : Form
    {
        private readonly RoomBUS roomBUS;
        private RoomBookingBUS roomBookingBUS;
        private readonly EmployeeBUS employeeBUS;
        public SpaBookingForm()
        {
            InitializeComponent();
            roomBUS = new RoomBUS();
            roomBookingBUS = new RoomBookingBUS();
            employeeBUS = new EmployeeBUS();
        }

        private void SpaBookingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            bindingSource1.DataSource = roomBookingBUS.GetAllSpaPetBookings();
            dgSpaBooking.AutoGenerateColumns = false;
            dgSpaBooking.DataSource = bindingSource1;
        }

        private void AddNewSpaBooking_Click(object sender, EventArgs e)
        {
            AddSpaBookingForm addForm = new AddSpaBookingForm();
            addForm.FormClosed += AddSpaBooking_FormClosed;
            addForm.MdiParent = this.MdiParent;
            addForm.FormBorderStyle = FormBorderStyle.None;
            addForm.Dock = DockStyle.Fill;
            addForm.Show();
        }

        private void AddSpaBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void dgSpaBooking_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgSpaBooking.Columns[e.ColumnIndex].Name == "Status")
            {
                var bookingId = Convert.ToInt32(dgSpaBooking.Rows[e.RowIndex].Cells["ID"].Value);
                var roomId = Convert.ToInt32(dgSpaBooking.Rows[e.RowIndex].Cells["RoomID"].Value);
                var employeeId = Convert.ToInt32(dgSpaBooking.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                var status = dgSpaBooking.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                roomBookingBUS.UpdateBookingStatusAndRoomEmployee(bookingId, roomId, employeeId, status);
            }
        }
    }
}
