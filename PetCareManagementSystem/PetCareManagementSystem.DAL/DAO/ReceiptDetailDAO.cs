using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class ReceiptDetailDAO
    {
        private SqlDataAccessHelper dataProvider;
        private DataTable dt;
        public ReceiptDetailDAO()
        {
            dataProvider = new SqlDataAccessHelper();
        }

        public bool AddReceiptDetail(int ReceiptID, int SupplierID, int ProductID, int Quantity, decimal UnitPrice, decimal TotalPricePro)
        {
            string query = "INSERT INTO ReceiptDetail (ReceiptID,SupplierID, ProductID,  Quantity, UnitPrice, TotalPricePro) VALUES (@ReceiptID,@SupplierID, @ProductID,  @Quantity, @UnitPrice, @TotalPricePro)";

            try
            {

                SqlParameter[] parameters =
                {
            new SqlParameter("@ReceiptID", ReceiptID),

            new SqlParameter("@SupplierID", SupplierID),
            new SqlParameter("@ProductID", ProductID),
            new SqlParameter("@Quantity", Quantity),
            new SqlParameter("@UnitPrice", UnitPrice),
            new SqlParameter("@TotalPricePro", TotalPricePro)        };

                bool insertionSuccess = dataProvider.ExecuteInsertQuery(query, parameters);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
