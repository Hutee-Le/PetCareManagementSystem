using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class RoomDAO
    {
        private SqlDataAccessHelper _helper;

        public RoomDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public DataTable GetAllRooms()
        {
            string query = "SELECT * FROM Rooms";
            return _helper.ExecuteSelectAllQuery(query);
        }
    }
}
