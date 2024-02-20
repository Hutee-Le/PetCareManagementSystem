using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using PetCareManagementSystem.DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class RoomBookingBUS
    {
        private RoomBookingDAO _dao;
        private RoomDAO roomDAO;
        private EmployeeDAO employeeDAO;

        public RoomBookingBUS()
        {
            _dao = new RoomBookingDAO();
            roomDAO = new RoomDAO();
            employeeDAO = new EmployeeDAO();
        }

        public int CreateRoomBooking(RoomBooking roomBooking)
        {
            return _dao.CreateRoomBooking(roomBooking.RoomId, roomBooking.PetId, roomBooking.EmployeeId, roomBooking.Date, roomBooking.StartTime, roomBooking.EndTime, roomBooking.TotalPrice, roomBooking.TotalDiscount, roomBooking.Status, roomBooking.PaymentStatus);
        }

        public bool DeleteRoomBooking(int bookingId)
        {
            return _dao.DeleteRoomBooking(bookingId);
        }

        public List<SpaPetBookingDetail> GetAllSpaPetBookings()
        {
            DataTable dtBookings = _dao.GetAllSpaPetBookings();
            List< SpaPetBookingDetail> listBookings = new List<SpaPetBookingDetail>();

            foreach (DataRow row in dtBookings.Rows)
            {
                listBookings.Add(new SpaPetBookingDetail
                {
                    BookingID = Convert.ToInt32(row["BookingID"]),
                    RoomID = Convert.ToInt32(row["RoomID"]),
                    EmployeeID = Convert.ToInt32(row["EmployeeID"]),
                    CustomerName = row["Name"].ToString(),
                    Date = Convert.ToDateTime(row["Date"]),
                    ServiceName = row["ServiceName"].ToString(),
                    TotalPrice = Convert.ToDecimal(row["TotalPrice"]),
                    EmployeeName = row["EmployeesName"].ToString(),
                    PetName = row["PetsName"].ToString(),
                    BreedName = row["BreedName"].ToString(),
                    SpeciesName = row["SpeciesName"].ToString(),
                    Status = row["Status"].ToString(),
                    PaymentStatus = row["PaymentStatus"].ToString(),
                    TypeName = row["TypeName"].ToString(),
                });
            }

            return listBookings;
        }

        public void UpdateBookingPaymentStatus(int bookingId, string paymentStatus)
        {
            _dao.UpdateBookingPaymentStatus(bookingId, paymentStatus);
        }

        public void UpdateBookingStatusAndRoomEmployee(int bookingId, int roomId, int employeeId, string status)
        {
            _dao.UpdateBookingStatus(bookingId, status);

            if (status == "Completed" || status == "Cancelled" || status == "Rejected")
            {
                roomDAO.UpdateRoomStatus(roomId, "Available");
                employeeDAO.UpdateEmployeeStatus(employeeId, "Available");
            }

            if (status == "Confirmed" || status == "In Progress")
            {
                roomDAO.UpdateRoomStatus(roomId, "Unavailable");
                employeeDAO.UpdateEmployeeStatus(employeeId, "Busy");
            }
        }
    }
}
