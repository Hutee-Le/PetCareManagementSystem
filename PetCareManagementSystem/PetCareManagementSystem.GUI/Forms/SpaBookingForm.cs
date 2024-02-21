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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PetCareManagementSystem.GUI.Forms
{
    public partial class SpaBookingForm : Form
    {
        private readonly RoomBUS roomBUS;
        private RoomBookingBUS roomBookingBUS;
        private readonly EmployeeBUS employeeBUS;
        private readonly BookingDetailsBUS bookingDetailsBUS;

        public SpaBookingForm()
        {
            InitializeComponent();
            roomBUS = new RoomBUS();
            roomBookingBUS = new RoomBookingBUS();
            employeeBUS = new EmployeeBUS();
            bookingDetailsBUS = new BookingDetailsBUS();
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

            if(e.RowIndex >= 0 && dgSpaBooking.Columns[e.ColumnIndex].Name == "PaymentStatus")
            {
                var bookingId = Convert.ToInt32(dgSpaBooking.Rows[e.RowIndex].Cells["ID"].Value);
                var paymentStatus = dgSpaBooking.Rows[e.RowIndex].Cells["PaymentStatus"].Value.ToString();

                roomBookingBUS.UpdateBookingPaymentStatus(bookingId, paymentStatus);
            }
        }

        private void dgSpaBooking_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // Bỏ qua header

            if (e.ColumnIndex == dgSpaBooking.Columns["Status"].Index || e.ColumnIndex == dgSpaBooking.Columns["PaymentStatus"].Index)
            {
                string statusValue = dgSpaBooking["Status", e.RowIndex].Value?.ToString() ?? string.Empty;
                string paymentStatusValue = dgSpaBooking["PaymentStatus", e.RowIndex].Value?.ToString() ?? string.Empty;

                // Vẽ cell 'Status' nếu 'Status' là "Completed"
                if (e.ColumnIndex == dgSpaBooking.Columns["Status"].Index && statusValue == "Completed")
                {
                    PaintCell(e, "Completed", Color.FromArgb(204, 255, 204), Color.Green, 10);

                }

                // Vẽ cell 'PaymentStatus' nếu 'Status' là "Completed" và 'PaymentStatus' là "Paid"
                if (e.ColumnIndex == dgSpaBooking.Columns["PaymentStatus"].Index && statusValue == "Completed" && paymentStatusValue == "Paid")
                {
                    PaintCell(e, "Paid", Color.FromArgb(8, 177, 186), Color.Turquoise, 10);
                }

                // Vẽ cell 'PaymentStatus' nếu 'Status' là "Rejected" hoặc "Cancelled"
                if (e.ColumnIndex == dgSpaBooking.Columns["PaymentStatus"].Index && statusValue == "Cancelled")
                {
                    PaintCell(e, "---", e.CellStyle.BackColor, Color.Black, 0);
                }
            }
        }

        private void PaintCell(DataGridViewCellPaintingEventArgs e, string text, Color backColor, Color textColor, int padding)
        {
            
            Rectangle smallerRect = new Rectangle(e.CellBounds.X + padding, e.CellBounds.Y + padding, e.CellBounds.Width - 2 * padding, e.CellBounds.Height - 2 * padding);

            using (SolidBrush whiteBrush = new SolidBrush(Color.White)) // Dùng cho nền trắng của toàn bộ cell
            {
                using (SolidBrush backColorBrush = new SolidBrush(backColor)) // Dùng cho nền của hình chữ nhật nhỏ hơn
                {
                    using (SolidBrush textBrush = new SolidBrush(textColor)) // Dùng cho văn bản
                    {
                        // Bước 1: Vẽ màu nền trắng cho toàn bộ cell
                        e.Graphics.FillRectangle(whiteBrush, e.CellBounds);

                        // Bước 2: Vẽ hình chữ nhật nhỏ hơn với màu nền tùy chỉnh
                        e.Graphics.FillRectangle(backColorBrush, smallerRect);

                        // Đặt văn bản
                        TextRenderer.DrawText(e.Graphics, text, e.CellStyle.Font, smallerRect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                        // Vẽ đường viền
                        e.Paint(e.CellBounds, DataGridViewPaintParts.Border);

                        //// Đánh dấu cell là chỉ đọc
                        dgSpaBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    }
                }
            }
            e.Handled = true;
        }

        private void dgSpaBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSpaBooking.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Xác nhận với người dùng trước khi xóa
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa đơn đặt lịch này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int bookingId = Convert.ToInt32(dgSpaBooking.Rows[e.RowIndex].Cells["ID"].Value);

                    // Nếu người dùng xác nhận muốn xóa
                    try
                    {
                        // Xóa BookingDetails trước
                        if (bookingDetailsBUS.DeleteBookingDetails(bookingId))
                        {
                            // Sau đó xóa RoomBooking
                            if (roomBookingBUS.DeleteRoomBooking(bookingId))
                            {
                                // Cập nhật DataGridView
                                dgSpaBooking.Rows.RemoveAt(e.RowIndex);
                                MessageBox.Show("Đơn đặt lịch đã được xóa thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi xóa đơn đặt lịch.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi xóa chi tiết đặt lịch.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }

        private string currentSortColumn = null;
        private SortOrder currentSortOrder = SortOrder.None;

        private void dgSpaBooking_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dgSpaBooking.Columns[e.ColumnIndex];
            // Kiểm tra nếu cột hiện tại không phải là cột được nhấn, reset hướng sắp xếp
            if (currentSortColumn != column.DataPropertyName)
            {
                currentSortOrder = SortOrder.None; // Reset khi thay đổi cột
            }

            // Đổi chiều hướng sắp xếp
            currentSortOrder = currentSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

            // Cập nhật biến theo dõi cột hiện tại
            currentSortColumn = column.DataPropertyName;

            // Cập nhật SortGlyphDirection cho tất cả các cột
            foreach (DataGridViewColumn col in dgSpaBooking.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            column.HeaderCell.SortGlyphDirection = currentSortOrder;

            // Lấy hướng sắp xếp dưới dạng chuỗi
            string sortDirection = currentSortOrder == SortOrder.Ascending ? "ASC" : "DESC";

            // Tải lại dữ liệu đã sắp xếp
            LoadSortedData(column.DataPropertyName, sortDirection);
        }

        private void LoadSortedData(string columnName, string sortDirection)
        {
            bindingSource1.DataSource = roomBookingBUS.GetSortedSpaPetBookings(columnName, sortDirection);
            dgSpaBooking.DataSource = bindingSource1;
        }
        
    }
}
