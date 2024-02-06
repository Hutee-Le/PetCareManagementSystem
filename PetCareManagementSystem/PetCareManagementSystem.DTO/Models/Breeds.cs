using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Breeds
    {
        public int BreedId { get; set; }

        public int? SpeciesId { get; set; }

        public string BreedName { get; set; }

        public virtual ICollection<Pets> Pets { get; set; } = new List<Pets>();

        public virtual Species Species { get; set; }
    }
}
