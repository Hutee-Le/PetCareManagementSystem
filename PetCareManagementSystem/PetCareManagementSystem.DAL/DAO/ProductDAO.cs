using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class ProductDAO
    {

        private SqlDataAccessHelper dataProvider;
        private DataTable dt;
        public ProductDAO()
        {
            dataProvider = new SqlDataAccessHelper();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable(); // Initialize DataTable here
            string query = "Select * from Product";
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
            string query = "SELECT * FROM CategoryProduct join Product on CategoryProduct.CateProID = Product.CateProID WHERE  Product.CateProID= @CateProID ";

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
        public DataTable getProductIDbyName(string ProductName)
        {
            DataTable dt = new DataTable();
            string query = "SELECT ProductID FROM Product WHERE ProductName = @ProductName";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@ProductName", ProductName) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dt;
        }

        public bool AddProduct(int CateProID, string ProductName, string Description, int UnitPrice)
        {
            string query = "INSERT INTO Product (CateProID, ProductName, Description,UnitPrice ) VALUES (@CateProID, @ProductName,@Description, @UnitPrice)";

            try
            {

                SqlParameter[] parameters =
                {
            new SqlParameter("@CateProID", CateProID),
            new SqlParameter("@ProductName", ProductName),
            new SqlParameter("@Description", Description),
            new SqlParameter("@UnitPrice", UnitPrice)
        };

                bool insertionSuccess = dataProvider.ExecuteInsertQuery(query, parameters);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateProduct(int CateProID, string ProductName, string Description, int UnitPrice)
        {
            string query = "INSERT INTO Product (CateProID, ProductName, Description,UnitPrice ) VALUES (@CateProID, @ProductName,@Description, @UnitPrice)";

            try
            {

                SqlParameter[] parameters =
                {
            new SqlParameter("@CateProID", CateProID),
            new SqlParameter("@ProductName", ProductName),
            new SqlParameter("@Description", Description),
            new SqlParameter("@UnitPrice", UnitPrice)
        };

                bool insertionSuccess = dataProvider.ExecuteInsertQuery(query, parameters);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteProduct(int ProductID)
        {
            string query = "DELETE FROM Product WHERE ProductID = @ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", SqlDbType.Int) { Value = ProductID } };

            bool updateSuccess = dataProvider.ExecuteDeleteQuery(query, parameters);
            return updateSuccess;
        }
    }
}
