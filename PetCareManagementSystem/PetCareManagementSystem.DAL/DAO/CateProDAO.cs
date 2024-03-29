﻿using System;
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
        public string GetNameCateById(int cateId)
        {
            string cateName = ""; // Initialize the category name

            DataTable dt = new DataTable();
            string query = "SELECT CateProName FROM CategoryProduct WHERE CateProID = @CateProID";
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@CateProID", cateId) };
                dt = dataProvider.ExecuteSelectQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    // Lấy tên loại sản phẩm từ dòng đầu tiên và cột đầu tiên của DataTable
                    cateName = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return cateName;
        }

        public DataTable getCateName()
        {
            DataTable dt = new DataTable(); // Initialize DataTable here
            string query = "SELECT CateProName, COUNT(*) AS Total FROM Product p join CategoryProduct c on p.CateProID =c.CateProID GROUP BY CateProName";
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

        public DataTable getCateIDbyname(string CateName)
        {
            DataTable dt = new DataTable();
            string query = "SELECT CateProId FROM CategoryProduct WHERE CateProName = @CateProName";

            try
            {
                SqlParameter[] parameters = { new SqlParameter("@CateProName", CateName) };
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
