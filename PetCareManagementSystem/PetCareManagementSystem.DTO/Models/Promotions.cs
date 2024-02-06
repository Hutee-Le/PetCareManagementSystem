using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Promotions
    {
        public int PromotionId { get; set; }

        public string PromotionName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? DiscountPercent { get; set; }

        public virtual ICollection<RoomBooking> RoomBookings { get; set; } = new List<RoomBooking>();
    }
}
