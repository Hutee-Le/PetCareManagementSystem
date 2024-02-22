using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class EmployeeRoleBUS
    {
        private EmployeeRoleDAO employeeRoleDAO;

        public EmployeeRoleBUS()
        {
            employeeRoleDAO = new EmployeeRoleDAO();
        }

        public bool AddEmployeeRole(EmployeeRoles employeeRole)
        {
            return employeeRoleDAO.AddEmployeeAndRole(employeeRole.EmployeeID, employeeRole.RoleID);
        }
    }
}
