﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public DataTable GetSpaEmployeeDetails()
        {

            string query = "SELECT * FROM vw_SpaEmployeeDetails ORDER BY EmployeeID DESC";
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

        public bool AddEmployee(string name, string email, string password, string phoneNumber, string status, string address)
        {
            string query = "INSERT INTO Employees (Name, Email, Password, PhoneNumber, Status, Address) VALUES (@Name, @Email, @Password, @PhoneNumber, @Status, @Address)";

            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Status", status),
                new SqlParameter("@Address", address)
           };

            return dataAccessHelper.ExecuteInsertQuery(query, parameters);

        }

        public int GetLastInsertedId()
        {
            string query = "SELECT IDENT_CURRENT('Employees') AS LastID";
            return dataAccessHelper.ExecuteScalarQuery(query);
        }

        public bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE Email = @Email";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            int count = Convert.ToInt32(dataAccessHelper.ExecuteScalarQuery(query, parameters));
            return count > 0;
        }

        public bool ChangePassword(int employeeId, string newPassword)
        {
            string query = "UPDATE Employees SET Password = @Password WHERE EmployeeID = @EmployeeId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", employeeId),
                new SqlParameter("@Password", newPassword)
            };

            return dataAccessHelper.ExecuteUpdateQuery(query, parameters);
        }

        public bool DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", employeeId) 
            };

            return dataAccessHelper.ExecuteDeleteQuery(query, parameters);
        }
    }
}
