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
    public partial class MainForm : Form
    {
        #region Fields

        private EmployeeBUS employeeBUS;
        private Employees _employees;
        private bool sidebarExpanded;
        private bool groomingCollapsed;
        private DashboardForm dashboardForm;
        private SpaBookingForm spaBookingForm;
        private BookingManagementForm bookingManagementForm;

        #endregion

        #region Constructor and Load

        public MainForm(Employees employees)
        {
            InitializeComponent();
            _employees = employees;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUserInfo();
            LoadDashboardForm();
        }

        #endregion

        private void UpdateUserInfo()
        {
            btnUserName.Text = _employees?.Name ?? "UserName";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CloseAllChildForms();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Close();
            }
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
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

        #region Sidebar

        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            AdjustSidebarWidth();
        }

        private void AdjustSidebarWidth()
        {
            if (sidebarExpanded)
            {
                ExpandSidebar();
            }
            else
            {
                CollapseSidebar();
            }
        }

        private void ExpandSidebar()
        {
            sidebarContainer.Width += 10;
            if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
            {
                sidebarExpanded = false;
                StopSidebarTimer();
                ResetButtonImageOffset();
            }
        }

        private void CollapseSidebar()
        {
            sidebarContainer.Width -= 10;
            if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
            {
                sidebarExpanded = true;
                StopSidebarTimer();
                ResetButtonImageOffset();
            }
        }

        private void StopSidebarTimer()
        {
            sidebarTime.Stop();
        }

        private void ResetButtonImageOffset()
        {
            int offsetValue = sidebarExpanded ? 25 : 10;
            btnSpaTypes.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaCategory.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaEmployee.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaOrder.ImageOffset = new System.Drawing.Point(offsetValue, 0);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        #endregion

        #region Grooming

        private void GroomingTimer_Tick(object sender, EventArgs e)
        {
            AdjustGroomingContainerHeight();
        }

        private void AdjustGroomingContainerHeight()
        {
            if (groomingCollapsed)
            {
                GroomingContainer.Height -= 10;
                if (GroomingContainer.Height == GroomingContainer.MinimumSize.Height)
                {
                    groomingCollapsed = false;
                    GroomingTimer.Stop();
                }
            }
            else
            {
                GroomingContainer.Height += 10;
                if (GroomingContainer.Height == GroomingContainer.MaximumSize.Height)
                {
                    groomingCollapsed = true;
                    GroomingTimer.Stop();
                }
            }
        }

        private void btnGrooming_Click(object sender, EventArgs e)
        {
            GroomingTimer.Start();
        }

        private void btnGrooming_MouseHover(object sender, EventArgs e)
        {
            btnArrowDown.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow;
        }

        private void btnGrooming_MouseLeave(object sender, EventArgs e)
        {
            btnArrowDown.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow_down;
        }

        #endregion

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenDashboardForm();
        }

        private void OpenDashboardForm()
        {
            if (dashboardForm == null)
            {
                dashboardForm = new DashboardForm();
                ConfigureChildForm(dashboardForm);
            }
            else
            {
                dashboardForm.Activate();
            }
        }

        private void ConfigureChildForm(Form childForm)
        {
            childForm.FormClosed += DashboardChildForm_FormClosed;
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void DashboardChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void btnBookingService_Click(object sender, EventArgs e)
        {
            if(bookingManagementForm == null)
            {
                bookingManagementForm = new BookingManagementForm();
                bookingManagementForm.FormClosed += BookingManagement_FormClosed;
                bookingManagementForm.MdiParent = this;
                bookingManagementForm.FormBorderStyle = FormBorderStyle.None;
                bookingManagementForm.Dock = DockStyle.Fill;
                bookingManagementForm.Show();
            }
            else
            {
                bookingManagementForm.Activate();
            }
        }

        private void BookingManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookingManagementForm = null;
        }

        private void btnSpaOrder_Click(object sender, EventArgs e)
        {
            if(spaBookingForm == null)
            {
                spaBookingForm = new SpaBookingForm();
                spaBookingForm.FormClosed += SpaBooking_FormClosed;
                spaBookingForm.MdiParent = this;
                spaBookingForm.FormBorderStyle = FormBorderStyle.None;
                spaBookingForm.Dock = DockStyle.Fill;
                spaBookingForm.Show();
            }
            else
            {
                spaBookingForm.Activate();
            }
        }

        private void SpaBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            spaBookingForm = null;
        }

        private void LoadDashboardForm()
        {
            OpenDashboardForm();
        }
    }
}
