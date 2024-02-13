using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class CateProDAO
    {
        private SqlDataAccessHelper dataProvider;
        // private DataTable dt;
        public CateProDAO()
        {
            dataProvider = new SqlDataAccessHelper();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable(); // Initialize DataTable here
            string query = "Select * from CategoryProduct";
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
        public DataTable GetProByCateId(int cateId)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CategoryProduct join Product on CategoryProduct.CateProID = Product.CateProID WHERE CateProID= @CateProID ";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@CateProID", cateId) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dt;
        }
    }
}
