using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }

        public int? CustomerTypeId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ImageUrl { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string PhoneNumber { get; set; }

        public virtual CustomerTypes CustomerTypes { get; set; }

        public virtual ICollection<Pets> Pets { get; set; } = new List<Pets>();
    }
}
