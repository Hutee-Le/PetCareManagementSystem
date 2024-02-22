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
            string sql = "INSERT INTO EmployeeRoles (EmployeeID, RoleID) VALUES (@EmployeeId, @RoleId)";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@EmployeeId", employeeID),
                new SqlParameter("@RoleId", roleID),
           };

           return sqlDataAccessHelper.ExecuteInsertQuery(sql, parameters);
        }
    }
}
