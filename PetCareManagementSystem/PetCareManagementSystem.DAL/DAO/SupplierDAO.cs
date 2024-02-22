using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class SupplierDAO
    {
        private SqlDataAccessHelper dataProvider;
         private DataTable dt;
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
        public string GetSupnameByID(int supID)
        {
            string supName = "NULL"; // Initialize the category name
            string query = "SELECT SupplierName FROM Supplier WHERE SupplierID = @SupplierID  ";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@SupplierID", supID) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    // Lấy tên loại sản phẩm từ dòng đầu tiên và cột đầu tiên của DataTable
                    supName = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return supName;
        }
    }
}
