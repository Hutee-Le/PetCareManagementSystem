using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class EmployeeRoles
    {
        public int EmployeeRoleID { get; set; }
        public int? EmployeeID { get; set; }
        public int? RoleID { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
