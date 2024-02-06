using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class EmployeeBUS
    {
        private EmployeeDAO employeeDAO;

        public EmployeeBUS()
        {
            employeeDAO = new EmployeeDAO();
        }

        public bool AuthenticateUser(string email, string password)
        {
            // Check if the email and password are not empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                // Additional validation, if required
                return false;
            }

            return employeeDAO.ValidateUserCredentials(email, password);
        }

        public Employees GetEmployeeByEmail(string email)
        {
            DataTable result = employeeDAO.GetEmployeeByEmail(email);

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                Employees employee = new Employees
                {
                    EmployeeId = Convert.ToInt32(row["EmployeeId"]),
                    Name = row["Name"].ToString(),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    ImageUrl = row["ImageUrl"].ToString(),
                    Address = row["Address"].ToString(),
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Status = row["Status"].ToString()
                };

                // Duyệt qua các dòng để lấy tất cả các vai trò
                foreach (DataRow roleRow in result.Rows)
                {
                    Roles role = new Roles
                    {
                        RoleId = Convert.ToInt32(roleRow["RoleId"]),
                        RoleName = roleRow["RoleName"].ToString()
                    };

                    // Gán vai trò vào danh sách vai trò của người dùng
                    employee.EmployeeRoles.Add(new EmployeeRoles { Roles = role });
                }

                return employee;
            }

            return null;
        }
    }
}
