using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class CategoryProduct
    {
        public int CateProId { get; set; }

        public string CateProName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
