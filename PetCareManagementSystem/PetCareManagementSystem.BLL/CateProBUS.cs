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
    }
}
