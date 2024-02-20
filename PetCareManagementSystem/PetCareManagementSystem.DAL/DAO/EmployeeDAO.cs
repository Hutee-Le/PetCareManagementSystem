using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class EmployeeDAO
    {
        private SqlDataAccessHelper dataAccessHelper;

        public EmployeeDAO()
        {
            dataAccessHelper = new SqlDataAccessHelper();
        }

        public DataTable GetAllEmployees()
        {
            string query = "SELECT * FROM Employees";
            return dataAccessHelper.ExecuteSelectAllQuery(query);
        }

        public bool ValidateUserCredentials(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE Email = @Email AND Password = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email },
                new SqlParameter("@Password", SqlDbType.VarChar) { Value = password }
            };

            DataTable result = dataAccessHelper.ExecuteSelectQuery(query, parameters);

            return result != null && result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        public DataTable GetEmployeeByEmail(string email)
        {
            string query = @"
            SELECT e.*, r.RoleId, r.RoleName
            FROM Employees e
            INNER JOIN EmployeeRoles er ON e.EmployeeId = er.EmployeeID
            INNER JOIN Roles r ON er.RoleID = r.RoleId
            WHERE e.Email = @Email";

            SqlParameter[] parameters = {
                new SqlParameter("@Email", SqlDbType.VarChar) { Value = email }
            };

            return dataAccessHelper.ExecuteSelectQuery(query, parameters);
        }

        public bool UpdateEmployeeStatus(int employeeId, string status)
        {
            string query = "UPDATE Employees SET Status = @Status WHERE EmployeeID = @EmployeeId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", employeeId),
                new SqlParameter("@Status", status)
            };

            return dataAccessHelper.ExecuteUpdateQuery(query, parameters);
        }
    }
}
