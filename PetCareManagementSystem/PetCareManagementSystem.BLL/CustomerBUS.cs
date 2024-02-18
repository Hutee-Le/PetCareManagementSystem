﻿using PetCareManagementSystem.DAL.DAO;
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

        public List<Customers> GetAll()
        {
            DataTable dtCustomers = _dao.GetAll();
            List<Customers> customers = new List<Customers>();

            foreach (DataRow dr in dtCustomers.Rows)
            {
                Customers customer = new Customers
                {
                    CustomerId = Convert.ToInt32(dr["CustomerID"]),
                    CustomerTypeId = Convert.ToInt32(dr["CustomerTypeID"]),
                    Name = dr["Name"].ToString(),
                    Email = dr["Email"].ToString(),
                    Password = dr["Password"].ToString(),
                    ImageUrl = dr["ImageUrl"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    Address = dr["Address"].ToString(),
                    UpdateTime = Convert.ToDateTime(dr["UpdateTime"]),
                    PhoneNumber = dr["PhoneNumber"].ToString()
                };
                customers.Add(customer);
            }
            return customers;
        }
    }
}