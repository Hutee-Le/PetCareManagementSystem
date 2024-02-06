using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Pets
    {
        public int PetId { get; set; }

        public int? BreedId { get; set; }

        public int? CustomerId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public DateTime? BirthDate { get; set; }

        public int? Age { get; set; }

        public string Gender { get; set; }

        public virtual Breeds Breeds { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual ICollection<RoomBooking> RoomBookings { get; set; } = new List<RoomBooking>();
    }
}
