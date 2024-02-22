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
            string query = "SELECT * FROM Receipt ORDER BY ReceiptDate DESC;";
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

   
        public string GetEmployeenameByID(int EmployeeID)
        {
            string employName = ""; // Initialize the category name
            string query = "SELECT Name FROM Receipt r join Employees e on r.EmployeeID= e.EmployeeID WHERE e.EmployeeID = @EmployeeID  ";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@EmployeeID", EmployeeID) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    // Lấy tên loại sản phẩm từ dòng đầu tiên và cột đầu tiên của DataTable
                    employName = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return employName;
        }
        public DataTable GetReceiptAnalisys()
        {

            string query = "SELECT * FROM Receipt WHERE ReceiptDate >= DATEADD(DAY, -7, GETDATE());";
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
        public DataTable GetReceiptbymonth()
        {

            string query = "SELECT* FROM Receipt WHERE YEAR(ReceiptDate) = YEAR(GETDATE()) AND MONTH(ReceiptDate) = MONTH(GETDATE());";
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
        public DataTable GetReceiptToday()
        {

            string query = "SELECT* FROM Receipt WHERE CONVERT(date, ReceiptDate) = CONVERT(date, GETDATE());";
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
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
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
        public string FormatCurrency(decimal amount)
        {
            // Định dạng số tiền theo tiền Việt Nam
            string formattedAmount = string.Format("{0:N0} VNĐ", amount);
            return formattedAmount;
        }
        public string countSumReceipt()
        {
            string SumReceipt = ""; // Initialize latestReceiptID here
            string query = "SELECT SUM(TotalAmount) FROM Receipt";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    decimal sum = Convert.ToDecimal(dt.Rows[0][0]);
                    SumReceipt = FormatCurrency(sum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SumReceipt;
        }

        public int countPro1month()
        {
            
            int productCount = -1; // Initialize latestReceiptID here
            string query = "SELECT SUM(Quantity) FROM ReceiptDetail rd join Receipt r on rd.ReceiptID= r.ReceiptID WHERE YEAR(r.ReceiptDate) = YEAR(GETDATE()) AND MONTH(r.ReceiptDate) = MONTH(GETDATE());";
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

        public int countProToday()
        {

            int recCount = -1; // Initialize latestReceiptID here
            string query = "SELECT SUM(Quantity) FROM ReceiptDetail rd join Receipt r on rd.ReceiptID= r.ReceiptID WHERE CONVERT(date, r.ReceiptDate) = CONVERT(date, GETDATE());";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    recCount = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return recCount;
        }



        public int countPro7days()
        {

            int recCount = -1; // Initialize latestReceiptID here
            string query = "SELECT SUM(Quantity) FROM ReceiptDetail rd join Receipt r on rd.ReceiptID= r.ReceiptID WHERE r.ReceiptDate >= DATEADD(DAY, -7, GETDATE());";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    recCount = Convert.ToInt32(dt.Rows[0][0]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return recCount;
        }


        public string countReceipt1month()
        {
            string SumReceipt = ""; // Initialize latestReceiptID here
            string query = "SELECT SUM([TotalAmount]) FROM Receipt WHERE YEAR(ReceiptDate) = YEAR(GETDATE()) AND MONTH(ReceiptDate) = MONTH(GETDATE());";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    decimal sum = Convert.ToDecimal(dt.Rows[0][0]);
                    SumReceipt = FormatCurrency(sum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SumReceipt;
        }

        public string countReceipt7days()
        {
            string SumReceipt = ""; // Initialize latestReceiptID here
            string query = "SELECT SUM([TotalAmount]) FROM Receipt WHERE YEAR(ReceiptDate) = YEAR(GETDATE()) AND MONTH(ReceiptDate) = MONTH(GETDATE());";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    decimal sum = Convert.ToDecimal(dt.Rows[0][0]);
                    SumReceipt = FormatCurrency(sum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SumReceipt;
        }
        public string countReceiptToday()
        {
            string SumReceipt = ""; // Initialize latestReceiptID here
            string query = "SELECT SUM([TotalAmount]) FROM Receipt WHERE CONVERT(date, ReceiptDate) = CONVERT(date, GETDATE());";
            try
            {
                DataTable dt = dataProvider.ExecuteSelectAllQuery(query);
                if (dt.Rows.Count > 0)
                {
                    // Parse the count from the first row and first column of the DataTable
                    decimal sum = Convert.ToDecimal(dt.Rows[0][0]);
                    SumReceipt = FormatCurrency(sum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return SumReceipt;
        }
    }
}
