using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public bool UpdateRoomStatus(int roomId, string status)
        {
            string query = "UPDATE Rooms SET Status = @Status WHERE RoomID = @RoomId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoomId", roomId),
                new SqlParameter("@Status", status)
            };

            return _helper.ExecuteUpdateQuery(query, parameters);
        }
    }
}
