using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class PetDAO
    {
        private SqlDataAccessHelper _helper;
        public PetDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public DataTable GetPetsByCustomerId(int customerId)
        {
            string query = @"
            SELECT p.*
            FROM Pets p 
            INNER JOIN Customers c ON p.CustomerID = c.CustomerID
            WHERE c.CustomerID = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId }
            };

            return _helper.ExecuteSelectQuery(query, parameters);
        }
    }
}
