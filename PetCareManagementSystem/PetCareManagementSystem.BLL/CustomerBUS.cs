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
    public class CustomerBUS
    {
        private CustomerDAO _dao;

        public CustomerBUS()
        {
            _dao = new CustomerDAO();
        }

        public bool AddCustomer(Customers newCustomer)
        {
            return _dao.AddCustomer(newCustomer.Name, newCustomer.Email, newCustomer.Address, newCustomer.ImageUrl, newCustomer.Gender, newCustomer.Password, newCustomer.UpdateTime, newCustomer.PhoneNumber);
        }

        public bool DeleteCustomer(int customerId)
        {
            return _dao.DeleteCustomer(customerId);
        }

        public bool EmailExists(string email)
        {
            return _dao.EmailExists(email);
        }

        public List<Customers> GetAll()
        {
            DataTable dtCustomers = _dao.GetAll();
            List<Customers> customers = new List<Customers>();

            foreach (DataRow dr in dtCustomers.Rows)
            {
                Customers customer = new Customers
                {
                    CustomerId = Convert.ToInt32(dr["CustomerID"]),
                    Name = dr["Name"].ToString(),
                    Email = dr["Email"].ToString(),
                    Password = dr["Password"].ToString(),
                    ImageUrl = dr["ImageUrl"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    Address = dr["Address"].ToString(),
                    UpdateTime = Convert.ToDateTime(dr["UpdateTime"]),
                    PhoneNumber = dr["PhoneNumber"].ToString(),

                };
                if (dr["CustomerTypeID"] != DBNull.Value)
                {
                    customer.CustomerTypeId = Convert.ToInt32(dr["CustomerTypeID"]);
                }
                else
                {
                    customer.CustomerTypeId = null; 
                }
                customers.Add(customer);
            }
            return customers;
        }

        public DataTable GetCustomPetDetails()
        {
            return _dao.GetCustomPetDetails();
        }
    }
}
