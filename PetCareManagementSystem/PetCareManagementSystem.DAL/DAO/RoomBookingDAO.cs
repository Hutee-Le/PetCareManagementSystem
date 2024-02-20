using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class RoomBookingDAO
    {
        private SqlDataAccessHelper dataAccessHelper;

        public RoomBookingDAO()
        {
            dataAccessHelper = new SqlDataAccessHelper();
        }

        public DataTable GetAllSpaPetBookings()
        {
            string query = "SELECT * FROM SpaOrderView";
            return dataAccessHelper.ExecuteSelectAllQuery(query);
        }

        public int CreateRoomBooking(int? roomId, int? petId, int? employeeId, DateTime date, TimeSpan? startTime, TimeSpan? endTime, decimal? totalPrice, decimal? totalDiscount, string status, string paymentStatus)
        {
            string query = @"
                INSERT INTO RoomBookings (RoomID, PetID, EmployeeID, Date, StartTime, EndTime, TotalPrice, TotalDiscount, Status, PaymentStatus)
                VALUES (@RoomId, @PetId, @EmployeeId, @Date, @StartTime, @EndTime, @TotalPrice, @TotalDiscount, @Status, @PaymentStatus);
                SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoomId", roomId),
                new SqlParameter("@PetId", petId),
                new SqlParameter("@EmployeeId", employeeId),
                new SqlParameter("@Date", SqlDbType.DateTime){Value = date},
                new SqlParameter("@StartTime", SqlDbType.Time) {Value = startTime},
                new SqlParameter("@EndTime",  SqlDbType.Time) {Value = (object)endTime ?? DBNull.Value},
                new SqlParameter("@TotalPrice",totalPrice),
                new SqlParameter("@TotalDiscount", totalDiscount),
                new SqlParameter("@Status", status),
                new SqlParameter("@PaymentStatus", paymentStatus)
            };

            int bookingId = dataAccessHelper.ExecuteInsertAndGetId(query, parameters);
            return bookingId;
        }

        public bool UpdateBookingStatus(int bookingId, string status)
        {
            string query = "UPDATE RoomBookings SET Status = @status WHERE BookingID = @bookingId";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@bookingId", bookingId),
                new SqlParameter("@status", status)
            };

            return dataAccessHelper.ExecuteUpdateQuery(query, parameters);
        }
    }
}
