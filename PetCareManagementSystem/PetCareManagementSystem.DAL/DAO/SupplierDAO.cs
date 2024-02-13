using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class SupplierDAO
    {
        private SqlDataAccessHelper dataProvider;
        // private DataTable dt;
        public SupplierDAO()
        {
            dataProvider = new SqlDataAccessHelper();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable(); // Initialize DataTable here
            string query = "Select * from Supplier";
            try
            {
                dt = dataProvider.ExecuteSelectAllQuery(query);


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }


            return dt;
        }
    }
}
