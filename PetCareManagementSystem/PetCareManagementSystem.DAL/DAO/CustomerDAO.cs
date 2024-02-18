using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Customers";
            return _helper.ExecuteSelectAllQuery(query);
        }
    }
}
