﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class CustomerDAO
    {
        private SqlDataAccessHelper _helper;
        public CustomerDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public bool AddCustomer(string name, string email, string address, string imageUrl, string gender, string password, DateTime? updateTime, string phoneNumber)
        {
            string query = "INSERT INTO Customers (Name, Email, Address, ImageUrl, Gender, Password, UpdateTime, PhoneNumber) VALUES (@Name, @Email, @Address, @ImageUrl, @Gender, @Password, @UpdateTime, @PhoneNumber)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Email", email),
                new SqlParameter("@Address", address),
                new SqlParameter("@ImageUrl", imageUrl ?? (object)DBNull.Value), 
                new SqlParameter("@Gender", gender),
                new SqlParameter("@Password", password),
                new SqlParameter("@UpdateTime", updateTime ?? (object)DBNull.Value),
                new SqlParameter("@PhoneNumber", phoneNumber)
            };

            return _helper.ExecuteInsertQuery(query, parameters);
           
        }

        public bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE Email = @Email'";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            int count = Convert.ToInt32(_helper.ExecuteScalarQuery(query, parameters));
            return count > 0;
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Customers";
            return _helper.ExecuteSelectAllQuery(query);
        }

        public DataTable GetCustomPetDetails()
        {
            string query = "SELECT * FROM CustomPetDetails ORDER BY CustomerID DESC";
            return _helper.ExecuteSelectAllQuery(query);
        }
    }
}
