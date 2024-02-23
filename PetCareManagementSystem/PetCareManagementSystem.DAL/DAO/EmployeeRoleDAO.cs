using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetCareManagementSystem.DAL.DAO
{
    public class EmployeeRoleDAO
    {
        private SqlDataAccessHelper sqlDataAccessHelper;
        public EmployeeRoleDAO()
        {
            sqlDataAccessHelper = new SqlDataAccessHelper();
        }

        public bool AddEmployeeAndRole(int? employeeID, int? roleID)
        {
            string query = "INSERT INTO EmployeeRoles (EmployeeID, RoleID) VALUES (@EmployeeId, @RoleId)";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@EmployeeId", employeeID),
                new SqlParameter("@RoleId", roleID),
           };

           return sqlDataAccessHelper.ExecuteInsertQuery(query, parameters);
        }

        public bool DeleteEmployeeRolesByEmployeeId(int employeeId)
        {
            string query = @"DELETE FROM EmployeeRoles WHERE EmployeeID = @EmployeeId";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@EmployeeId", employeeId),
           };

            return sqlDataAccessHelper.ExecuteDeleteQuery(query, parameters);
        }
    }
}
