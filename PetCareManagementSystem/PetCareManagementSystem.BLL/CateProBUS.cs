using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class CateProBUS
    {

        private CateProDAO cateproDAO;
        public CateProBUS()
        {
            cateproDAO = new CateProDAO();
        }
        public List<DTO.Models.CategoryProduct> getAll()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = cateproDAO.getAll();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<CategoryProduct> listcate = new List<CategoryProduct>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CategoryProduct cate = new CategoryProduct();
                    cate.CateProId = Int32.Parse(dr["CateProId"].ToString());
                    cate.CateProName = dr["CateProName"].ToString();
                    cate.Description = dr["Description"].ToString();


                    listcate.Add(cate);
                }
            }


            return listcate;
        }
        public List<DTO.Models.CategoryProduct> getCateName()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = cateproDAO.getCateName();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<CategoryProduct> listcate = new List<CategoryProduct>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CategoryProduct cate = new CategoryProduct();
                    cate.CateProId = Int32.Parse(dr["Total"].ToString());
                    cate.CateProName = dr["CateProName"].ToString();
                    //cate.Description = dr["Description"].ToString();


                    listcate.Add(cate);
                }
            }


            return listcate;

        }
        public string GetNameCateById(int cateID)
        {
            string cateName = ""; // Initialize the category name

            try
            {
                // Gọi phương thức GetNameCateById trong cateproDAO để lấy tên loại sản phẩm
                cateName = cateproDAO.GetNameCateById(cateID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Trong trường hợp xảy ra ngoại lệ, trả về một giá trị đặc biệt để biểu thị sự thất bại
                return "Error: " + e.Message;
            }

            return cateName;
        }
        public int getCateIDbyName(string v)
        {
            DataTable dt = new DataTable();
            int CateId = -1;
            try
            {
                dt = cateproDAO.getCateIDbyname(v);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            if (dt.Rows.Count > 0)
            {
                // Nếu có dòng dữ liệu trong DataTable, lấy ProductID từ dòng đầu tiên
                DataRow dr = dt.Rows[0];
                CateId = Int32.Parse(dr["CateProId"].ToString());
            }

            return CateId;


        }

    }
}
