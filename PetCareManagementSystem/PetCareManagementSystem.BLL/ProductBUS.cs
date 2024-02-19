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
    public class ProductBUS
    {
        private ProductDAO productDAO;
        public ProductBUS()
        {
            productDAO = new ProductDAO();
        }
        public List<DTO.Models.Product> getAll()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = productDAO.getAll();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Product> list = new List<Product>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Product product = new Product();
                    product.ProductId = Int32.Parse(dr["ProductId"].ToString());
                    product.ProductName = dr["ProductName"].ToString();
                    product.CateProId = Int32.Parse(dr["CateProId"].ToString());
                    product.UnitPrice = Decimal.Parse(dr["UnitPrice"].ToString());
                    product.QuantityInStock = Int32.Parse(dr["QuantityInStock"].ToString());
                   

                    list.Add(product);
                }
            }


            return list;
        }

        public int countPro()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = productDAO.countPro();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public bool DeleteProduct(int IDProduct)
        {
            try
            {
                // Call UpdateStudent in the DAO to update the student
                bool updateSuccess = productDAO.DeleteProduct(IDProduct);

                return updateSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public Product getProductByID(int productID)
        {
            DataTable dt = new DataTable();
            Product product = new Product();
            string categoryName = ""; // Khởi tạo categoryName ở đây

            try
            {
                dt = productDAO.getProductByID(productID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                product.ProductId = Int32.Parse(dr["ProductId"].ToString());
                product.ProductName = dr["ProductName"].ToString();
                product.CateProId = Int32.Parse(dr["CateProId"].ToString());
                product.Description = dr["Description"].ToString();
                product.UnitPrice = Decimal.Parse(dr["UnitPrice"].ToString());
                product.QuantityInStock = Int32.Parse(dr["QuantityInStock"].ToString());

                // Lưu trữ categoryName
              //  categoryName = cateproDAO.GetNameCateById(product.CateProId);
            }

            // Sử dụng categoryName nếu cần thiết
            // Ví dụ: Console.WriteLine(categoryName);

            return product;
        }

        public List<DTO.Models.Product> GetProByCateId(int v)
        {
            DataTable dt = new DataTable();

            try
            {
                dt = productDAO.GetProByCateId(v);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Product> list = new List<Product>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Product product = new Product();
                    product.ProductId = Int32.Parse(dr["ProductId"].ToString());
                    product.ProductName = dr["ProductName"].ToString();
                    // product.CatePro = Int32.Parse(dr["CatePro"].ToString());
                    product.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                    product.Description = dr["Description"].ToString();
                    CategoryProduct categoryProduct = new CategoryProduct();
                    categoryProduct.CateProName = dr["CateProName"].ToString(); // Ví dụ, giả sử CateProName là tên của danh mục

                    // Gán đối tượng CategoryProduct vào thuộc tính CatePro của Product
                    product.CatePro = categoryProduct;
                    list.Add(product);
                }
            }


            return list;
        }


        public int getProductIDbyName(string v)
        {
            DataTable dt = new DataTable();
            int productId = -1;
            try
            {
                dt = productDAO.getProductIDbyName(v);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            if (dt.Rows.Count > 0)
            {
                // Nếu có dòng dữ liệu trong DataTable, lấy ProductID từ dòng đầu tiên
                DataRow dr = dt.Rows[0];
                productId = Int32.Parse(dr["ProductId"].ToString());
            }

            return productId;


        }



        public bool AddProduct(int CateProID, string ProductName, string Description, int UnitPrice)
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                bool insertionSuccess = productDAO.AddProduct(CateProID, ProductName, Description, UnitPrice);

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
