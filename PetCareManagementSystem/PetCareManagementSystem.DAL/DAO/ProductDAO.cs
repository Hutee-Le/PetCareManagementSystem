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
        public DataTable getProductByID(int proID)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Product WHERE ProductID = @ProductID  ";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@ProductID", proID) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
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
        public bool DeleteProduct(int ProductID)
        {
            string query = "DELETE FROM Product WHERE ProductID = @ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", SqlDbType.Int) { Value = ProductID } };

            bool updateSuccess = dataProvider.ExecuteDeleteQuery(query, parameters);
            return updateSuccess;
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

        public bool UpdateProduct(int ProductId,int CateProID, string ProductName, string Description, decimal UnitPrice)
        {
            string query = " UPDATE Product SET CateProID = @CateProID, ProductName = @ProductName, UnitPrice = @UnitPrice, Description = @Description WHERE ProductId = @ProductId";
           
            try
            {

                SqlParameter[] parameters =
                {
            new SqlParameter("@ProductId", ProductId),
            new SqlParameter("@CateProID", CateProID),
            new SqlParameter("@ProductName", ProductName),
            new SqlParameter("@Description", Description),
            new SqlParameter("@UnitPrice", UnitPrice)
        };

                bool insertionSuccess = dataProvider.ExecuteUpdateQuery1(query, parameters);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public int countPro()
        {
            int productCount = -1; // Initialize latestReceiptID here
            string query = "SELECT COUNT(*) FROM Product";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    productCount = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return productCount;
        }



        //public bool DeleteProduct(int ProductID)
        //{
        //    string query = "DELETE FROM Product WHERE ProductID = @ProductID";
        //    SqlParameter[] parameters = { new SqlParameter("@ProductID", SqlDbType.Int) { Value = ProductID } };

        //    bool updateSuccess = dataProvider.ExecuteDeleteQuery(query, parameters);
        //    return updateSuccess;
        //}
        public string getProNamebyID(int proID)
        {
            string proName = "NULL"; // Initialize the category name
            string query = "SELECT ProductName FROM Product WHERE ProductID = @ProductID  ";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@ProductID", proID) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    // Lấy tên loại sản phẩm từ dòng đầu tiên và cột đầu tiên của DataTable
                    proName = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return proName;
        }
    }
}
