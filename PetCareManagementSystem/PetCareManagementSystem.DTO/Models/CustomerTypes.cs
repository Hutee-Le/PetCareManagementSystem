using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class CustomerTypes
    {
        public int CustomerTypeId { get; set; }

        public string TypeName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Customers> Customers { get; set; } = new List<Customers>();
    }
}
