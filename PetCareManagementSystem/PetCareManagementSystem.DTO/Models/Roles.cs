using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Roles
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public virtual ICollection<EmployeeRoles> EmployeeRoles { get; set; } = new List<EmployeeRoles>();
    }
}
