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
        private RoomBookingBUS roomBookingBUS;
        public SpaBookingForm()
        {
            InitializeComponent();
            roomBookingBUS = new RoomBookingBUS();
          
        }

        private void SpaBookingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var spaPetBookings = roomBookingBUS.GetAllSpaPetBookings();
            dgSpaBooking.AutoGenerateColumns = false;
            dgSpaBooking.DataSource = spaPetBookings;
            dgSpaBooking.Refresh();
        }

        private void AddNewSpaBooking_Click(object sender, EventArgs e)
        {
            //AddSpaBookingForm addForm = new AddSpaBookingForm();

            //if (addForm.ShowDialog(this) == DialogResult.OK)
            //{

            //    LoadData();
            //}

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
    }
}
