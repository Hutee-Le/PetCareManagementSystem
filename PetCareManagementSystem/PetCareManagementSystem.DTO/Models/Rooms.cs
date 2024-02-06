using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Rooms
    {
        public int RoomId { get; set; }

        public string RoomName { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public virtual ICollection<RoomBooking> RoomBookings { get; set; } = new List<RoomBooking>();
    }
}
