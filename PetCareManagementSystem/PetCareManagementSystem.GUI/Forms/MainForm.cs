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

        private LoginForm _loginForm;
        private EmployeeBUS employeeBUS;
        private Employees _employees;
        private bool sidebarExpanded;
        private bool groomingCollapsed;
        private DashboardForm dashboardForm;
        private SpaBookingForm spaBookingForm;
        private BookingManagementForm bookingManagementForm;
        private ManageReceiptForm receiptForm;
        private AddProForm addProForm;
        #endregion

        #region Constructor and Load

        public MainForm(Employees employees, LoginForm loginForm)
        {
            InitializeComponent();
            _employees = employees;
            _loginForm = loginForm;
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

                this.Close();
                _loginForm.Show();
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

        private void SidebarTime_Tick(object sender, EventArgs e)
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
            SideMenuPanel.Width += 10;
            if (SideMenuPanel.Width == SideMenuPanel.MaximumSize.Width)
            {
                sidebarExpanded = false;
                StopSidebarTimer();
                ResetButtonImageOffset();
            }
        }

        private void CollapseSidebar()
        {
            SideMenuPanel.Width -= 10;
            if (SideMenuPanel.Width == SideMenuPanel.MinimumSize.Width)
            {
                sidebarExpanded = true;
                StopSidebarTimer();
                ResetButtonImageOffset();
            }
        }

        private void StopSidebarTimer()
        {
            SidebarTime.Stop();
        }

        private void ResetButtonImageOffset()
        {
            int offsetValue = sidebarExpanded ? 10 : 25;
            btnSpaTypes.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaCategory.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaEmployee.ImageOffset = new System.Drawing.Point(offsetValue, 0);
            btnSpaOrder.ImageOffset = new System.Drawing.Point(offsetValue, 0);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SidebarTime.Start();
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
                GroomingPanel.Height -= 10;
                if (GroomingPanel.Height == GroomingPanel.MinimumSize.Height)
                {
                    groomingCollapsed = false;
                    GroomingTimer.Stop();
                }
            }
            else
            {
                GroomingPanel.Height += 10;
                if (GroomingPanel.Height == GroomingPanel.MaximumSize.Height)
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

        private void BtnManageReceipt_Click(object sender, EventArgs e)
        {
            timerbtnRec.Start();
        }

        private void timerbtnRec_Tick(object sender, EventArgs e)
        {
            AdjustGroomingContainerHeight1();
        }
        private void AdjustGroomingContainerHeight1()
        {
            if (groomingCollapsed)
            {
                guna2Panel1.Height -= 10;
                if (guna2Panel1.Height == guna2Panel1.MinimumSize.Height)
                {
                    groomingCollapsed = false;
                    timerbtnRec.Stop();
                }
            }
            else
            {
                guna2Panel1.Height += 10;
                if (guna2Panel1.Height == guna2Panel1.MaximumSize.Height)
                {
                    groomingCollapsed = true;
                    timerbtnRec.Stop();
                }
            }
        }

        private void ManageReceipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            receiptForm = null;
        }
        private void AddPro_FormClosed(object sender, FormClosedEventArgs e)
        {
            addProForm = null;
        }
        private void ManagePro_Click(object sender, EventArgs e)
        {
            if (addProForm == null)
            {
                addProForm = new AddProForm();
                addProForm.FormClosed += AddPro_FormClosed;
                addProForm.MdiParent = this;
                addProForm.FormBorderStyle = FormBorderStyle.None;
                addProForm.Dock = DockStyle.Fill;
                addProForm.Show();
            }
            else
            {
                addProForm.Activate();
            }
        }

        private void btnGrooming_Click_1(object sender, EventArgs e)
        {
            GroomingTimer.Start();
        }

        private void BtnManRec_Click_1(object sender, EventArgs e)
        {
            if (receiptForm == null)
            {
                receiptForm = new ManageReceiptForm();
                receiptForm.FormClosed += ManageReceipt_FormClosed;
                receiptForm.MdiParent = this;
                receiptForm.FormBorderStyle = FormBorderStyle.None;
                receiptForm.Dock = DockStyle.Fill;
                receiptForm.Show();
            }
            else
            {
                receiptForm.Activate();
            }
        }

        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {

            btnArD.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow;

        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            btnArD.Image = global::PetCareManagementSystem.GUI.Properties.Resources.arrow;
        }  
    }
}
