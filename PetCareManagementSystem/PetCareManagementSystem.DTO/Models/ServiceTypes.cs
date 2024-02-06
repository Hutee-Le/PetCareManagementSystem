using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class ServiceTypes
    {
        public int ServiceTypeId { get; set; }

        public string TypeName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
