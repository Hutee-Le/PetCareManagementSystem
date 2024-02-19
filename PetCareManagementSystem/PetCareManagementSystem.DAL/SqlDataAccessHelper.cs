using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Security.Cryptography;

namespace PetCareManagementSystem.DAL
{
    public class SqlDataAccessHelper
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        /// <summary>
        /// Constructor for SqlDataAccessHelper class.
        /// </summary>
        public SqlDataAccessHelper()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        /// <summary>
        /// Open Database Connection if Closed or Broken.
        /// </summary>
        /// <returns>Opened SqlConnection.</returns>
        private SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        /// <summary>
        /// Execute SELECT query without parameters.
        /// </summary>
        /// <param name="_query">The SELECT query.</param>
        /// <returns>Resulting DataTable or null in case of an error.</returns>
        public DataTable ExecuteSelectAllQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand(_query, OpenConnection());
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                // Log the error
                Console.Write($"Error - Connection.executeSelectQuery - Query: {_query} \nException: {e.StackTrace}");
                return null;
            }
            finally
            {
                // Close the connection in the finally block to ensure it is closed even if an exception occurs.
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dataTable;
        }

        /// <summary>
        /// Execute SELECT query with parameters.
        /// </summary>
        /// <param name="_query">The SELECT query.</param>
        /// <param name="sqlParameters">Array of SQL parameters.</param>
        /// <returns>Resulting DataTable or null in case of an error.</returns>
        public DataTable ExecuteSelectQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand(_query, OpenConnection());
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Parameters.AddRange(sqlParameters);
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                // Log the error
                Console.Write($"Error - Connection.executeSelectQuery - Query: {_query} \nException: {e.StackTrace}");
                return null;
            }
            finally
            {
                // Close the connection in the finally block to ensure it is closed even if an exception occurs.
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dataTable;
        }

        public bool ExecuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        public int ExecuteInsertQuery1(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            int rowsAffected = 0;

            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                rowsAffected = myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                // Trả về -1 hoặc một giá trị đặc biệt để biểu thị lỗi
                return -1;
            }
            finally
            {
                // Đóng kết nối hoặc thực hiện các công việc dọn dẹp khác nếu cần
                //  myCommand.Connection.Close();
            }

            return rowsAffected; // Trả về số hàng bị ảnh hưởng
        }


        /// <method>
        /// Update Query
        /// </method>
        public bool ExecuteUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        /// <method>
        /// Delete Query
        /// </method>
        public bool ExecuteDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            //SqlCommand myCommand = new SqlCommand();
            try
            {
                //     using (SqlConnection connection = OpenConnection())
                //    SqlConnection tmp = OpenConnection();
                using (SqlCommand myCommand = new SqlCommand(_query, OpenConnection()))
                {
                    myCommand.Parameters.AddRange(sqlParameter);
                    myCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error - ExecuteInsertQuery - Query: " + _query + "\nException: \n" + e.StackTrace.ToString());
                return false;
            }
            
            finally
            {
                // Đóng kết nối trong khối finally để đảm bảo nó được đóng ngay cả khi có ngoại lệ xảy ra.
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return true;

        }
    }
}
