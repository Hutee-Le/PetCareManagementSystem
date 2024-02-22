using PetCareManagementSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            LoadSpaEmployeeData();
        }

        private void LoadSpaEmployeeData()
        {
            DataTable dt = employeeBUS.GetSpaEmployeeDetails();
            dt.Columns.Add("Image", typeof(Image));
            foreach (DataRow row in dt.Rows)
            {
                string imageUrl = row["ImageUrl"].ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    Image image = (Image)Properties.Resources.ResourceManager.GetObject(imageUrl);
                    row["Image"] = image;
                }
                else
                {
                    row["Image"] = Properties.Resources.default_avatar;
                }
            }
            dataGridViewSpaEmployees.AutoGenerateColumns = false;
            dataGridViewSpaEmployees.DataSource = dt;
        }

        private void AddNewSpaBooking_Click(object sender, EventArgs e)
        {
            AddSpaEmployeeForm addEmployeeForm = new AddSpaEmployeeForm();
            addEmployeeForm.FormClosed += AddEmployee_FormClosed;
            addEmployeeForm.MdiParent = this.MdiParent;
            addEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            addEmployeeForm.Dock = DockStyle.Right;
            addEmployeeForm.Show();
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadSpaEmployeeData();
        }

        private void dataGridViewSpaEmployees_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSpaEmployees.Columns["Status"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                bool toggled = Convert.ToBoolean(e.Value.ToString() == "Available");

                // Điều chỉnh kích thước của toggle và thumb
                int switchWidth = 50;
                int switchHeight = e.CellBounds.Height / 2;
                int switchX = e.CellBounds.X + (e.CellBounds.Width - switchWidth) / 2;
                int switchY = e.CellBounds.Y + (e.CellBounds.Height - switchHeight) / 2;
                int radius = switchHeight / 2; // Bán kính góc bo tròn

                // Vẽ nền toggle switch với góc bo tròn
                using (GraphicsPath switchPath = RoundedRect(new Rectangle(switchX, switchY, switchWidth, switchHeight), radius))
                {
                    e.Graphics.FillPath(new SolidBrush(toggled ? Color.MediumSlateBlue : Color.Gray), switchPath);
                }

                // Vẽ thumb với góc bo tròn
                int thumbSize = switchHeight - 6; // Kích thước của thumb nhỏ hơn switchHeight một chút
                int thumbX = toggled ? switchX + switchWidth - thumbSize - 3 : switchX + 3;
                using (GraphicsPath thumbPath = RoundedRect(new Rectangle(thumbX, switchY + 3, thumbSize, thumbSize), thumbSize / 2))
                {
                    e.Graphics.FillPath(new SolidBrush(Color.White), thumbPath);
                }

                e.Handled = true;
            }
        }

        private void dataGridViewSpaEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSpaEmployees.Columns["Status"].Index && e.RowIndex >= 0)
            {
                // Đảo trạng thái của toggle
                string currentValue = dataGridViewSpaEmployees[e.ColumnIndex, e.RowIndex].Value.ToString();
                string newValue = currentValue == "Available" ? "Busy" : "Available";

                // Cập nhật giá trị mới vào DataGridView
                dataGridViewSpaEmployees[e.ColumnIndex, e.RowIndex].Value = newValue;

                // Yêu cầu DataGridView vẽ lại ô để cập nhật hiển thị
                dataGridViewSpaEmployees.InvalidateCell(e.ColumnIndex, e.RowIndex);

                // Cập nhật trạng thái vào cơ sở dữ liệu
                int employeeId = Convert.ToInt32(dataGridViewSpaEmployees["EmployeeID", e.RowIndex].Value);
                UpdateEmployeeStatus(employeeId, newValue);
            }
        }

        private void UpdateEmployeeStatus(int employeeId, string status)
        {
            employeeBUS.UpdateEmployeeStatus(employeeId, status);
        }

        private void dataGridViewSpaEmployees_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSpaEmployees.Columns["Status"].Index && e.RowIndex >= 0)
            {
                dataGridViewSpaEmployees.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridViewSpaEmployees.Cursor = Cursors.Default;
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));
            // top left arc
            path.AddArc(arc, 180, 90);
            // top right arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            // bottom right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // bottom left arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
