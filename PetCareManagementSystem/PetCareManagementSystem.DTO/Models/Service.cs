using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        public int? ServiceTypeId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public decimal? Promotion { get; set; }

        public virtual ICollection<BookingDetails> BookingDetails { get; set; } = new List<BookingDetails>();

        public virtual ServiceTypes ServiceTypes { get; set; }
    }
}
