using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
