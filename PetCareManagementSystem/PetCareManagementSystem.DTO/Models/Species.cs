using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Species
    {
        public int SpeciesId { get; set; }

        public string SpeciesName { get; set; }

        public virtual ICollection<Breeds> Breeds { get; set; } = new List<Breeds>();
    }
}
