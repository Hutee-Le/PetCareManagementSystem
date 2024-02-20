using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class BookingDetailsDAO
    {
        private SqlDataAccessHelper _helper;

        public BookingDetailsDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public bool CreateBookingDetails(int? bookingId, int? serviceId, decimal? price, decimal? discount)
        {
            string query = @"
                INSERT INTO BookingDetails (BookingID, ServiceID, Price, Discount)
                VALUES (@BookingId, @ServiceId, @Price, @Discount);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BookingId",bookingId),
                new SqlParameter("@ServiceId", serviceId),
                new SqlParameter("@Price", price),
                new SqlParameter("@Discount",discount)
            };

            return _helper.ExecuteInsertQuery(query, parameters);
        }

        public bool DeleteBookingDetails(int bookingId)
        {
            string query = "DELETE FROM BookingDetails WHERE BookingID = @BookingID";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@BookingID", SqlDbType.Int) { Value = bookingId }
            };

            return _helper.ExecuteDeleteQuery(query, parameters);
        }
    }
}
