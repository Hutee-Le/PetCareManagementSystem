using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class RoomBUS
    {
        private RoomDAO _dao;

        public RoomBUS()
        {
            _dao = new RoomDAO();
        }

        public List<Rooms> GetALlRooms()
        {
            DataTable dtRooms = _dao.GetAllRooms();
            List<Rooms> rooms = new List<Rooms>();

            foreach (DataRow row in dtRooms.Rows)
            {
                Rooms room = new Rooms
                {
                    RoomId = Convert.ToInt32(row["RoomID"]),
                    RoomName = row["RoomName"].ToString(),
                    Description = row["Description"].ToString(),
                    Status = row["Status"].ToString(),
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
