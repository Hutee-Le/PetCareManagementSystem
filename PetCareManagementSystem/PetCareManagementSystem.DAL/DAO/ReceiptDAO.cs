using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class ReceiptDAO
    {
        private SqlDataAccessHelper dataProvider;
        private DataTable dt;
        public ReceiptDAO()
        {
            dataProvider = new SqlDataAccessHelper();
        }

        public DataTable getAll()
        {
            DataTable dt = new DataTable(); // Initialize DataTable here
            string query = "Select * from Receipt";
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

        public int getIDReceipt()
        {
            int latestReceiptID = -1; // Initialize latestReceiptID here
            string query = "SELECT MAX(ReceiptID) AS LatestReceiptID FROM Receipt";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    latestReceiptID = Convert.ToInt32(dt.Rows[0]["LatestReceiptID"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return latestReceiptID;
        }



        public int AddReceipt(int EmployeeID, DateTime ReceiptDate, decimal TotalAmount)
        {
            string query = "INSERT INTO Receipt (EmployeeID, ReceiptDate, TotalAmount) VALUES (@EmployeeID, @ReceiptDate, @TotalAmount)" +
                " ; SELECT SCOPE_IDENTITY();";

            try
            {

                SqlParameter[] parameters =
                {
            new SqlParameter("@EmployeeID", EmployeeID),
            new SqlParameter("@ReceiptDate", ReceiptDate),
            new SqlParameter("@TotalAmount", TotalAmount),
        };

                //int rowsAffected = dataProvider.ExecuteInsertQuery1(query, parameters);
                int rowsAffected = Convert.ToInt32(dataProvider.ExecuteInsertQuery1(query, parameters));
                return rowsAffected;

                //int receiptID = Convert.ToInt32(command.ExecuteScalar());
                //return receiptID;// Trả về số hàng bị ảnh hưởng

            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return -1; // Trả về -1 nếu có lỗi
            }
        }


        public bool DeleteReceipt(int ReceiptID)
        {
            string query = "DELETE FROM Receipt WHERE ReceiptID = @ReceiptID";
            SqlParameter[] parameters = { new SqlParameter("@ReceiptID", SqlDbType.Int) { Value = ReceiptID } };

            bool updateSuccess = dataProvider.ExecuteDeleteQuery(query, parameters);
            return updateSuccess;
        }

    }
}
