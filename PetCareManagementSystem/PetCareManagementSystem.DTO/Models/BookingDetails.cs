using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class BookingDetails
    {
        public int BookingDetailId { get; set; }

        public int? BookingId { get; set; }

        public int? ServiceId { get; set; }

        public decimal? Price { get; set; }

        public decimal? Discount { get; set; }

        public virtual RoomBooking Booking { get; set; }

        public virtual Service Service { get; set; }
    }
}
