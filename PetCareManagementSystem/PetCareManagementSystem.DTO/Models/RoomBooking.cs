using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class RoomBooking
    {
        public int BookingId { get; set; }

        public int? RoomId { get; set; }

        public int? PetId { get; set; }

        public int? EmployeeId { get; set; }

        public int? PromotionId { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? TotalDiscount { get; set; }
        public string Status { get; set; } 
        public string PaymentStatus { get; set; }

        public virtual ICollection<BookingDetails> BookingDetails { get; set; } = new List<BookingDetails>();

        public virtual Employees Employee { get; set; }

        public virtual Pets Pets { get; set; }

        public virtual Promotions Promotions { get; set; }

        public virtual Rooms Room { get; set; }
    }
}
