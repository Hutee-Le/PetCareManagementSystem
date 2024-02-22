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
    public class ReceiptDetailBUS
    {
        private ReceiptDetailDAO receiptDetailDAO;
        public ReceiptDetailBUS()
        {
            receiptDetailDAO = new ReceiptDetailDAO();
        }
        public List<DTO.Models.ReceiptDetail> getAll()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = receiptDetailDAO.getAll();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<ReceiptDetail> listReceipt = new List<ReceiptDetail>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ReceiptDetail receipt = new ReceiptDetail();
                    receipt.ReceiptDetailId = Int32.Parse(dr["ReceiptDetailId"].ToString());
                    receipt.SupplierId = Int32.Parse(dr["SupplierId"].ToString());
                    receipt.ProductId = Int32.Parse(dr["ProductId"].ToString());
                    receipt.Quantity = Int32.Parse(dr["Quantity"].ToString());
                    receipt.UnitPrice = Decimal.Parse(dr["UnitPrice"].ToString());
                    receipt.TotalPricePro = Decimal.Parse(dr["TotalPricePro"].ToString());
                   


                    listReceipt.Add(receipt);
                }
            }


            return listReceipt;
        }
        public bool AddReceiptDetail(int ReceiptID, int SupplierID, int ProductID, int Quantity, decimal UnitPrice, decimal TotalPricePro)
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                bool insertionSuccess = receiptDetailDAO.AddReceiptDetail(ReceiptID, SupplierID, ProductID, Quantity, UnitPrice, TotalPricePro);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


      
        public List<DTO.Models.ReceiptDetail> GetRecDetailByReceiptId(int recID)
        {
            // List<DataTable> dt = new List<DataTable>();
            List<DataRow> dt = new List<DataRow>();
            try
            {
                dt = receiptDetailDAO.GetRecDetailByReceiptId(recID);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            List<ReceiptDetail> listReceiptdetail = new List<ReceiptDetail>();

            // Bạn cần lặp qua từng bảng dữ liệu trong danh sách dt
            //foreach (DataTable table in dt)
            foreach (DataRow dr in dt)
            {
                //if (table.Rows.Count > 0)
                //{
                //    foreach (DataRow dr in table.Rows)
                //    {
                        ReceiptDetail rdetail = new ReceiptDetail();
                        rdetail.ReceiptDetailId = Int32.Parse(dr["ReceiptDetailId"].ToString());
                        rdetail.SupplierId = Int32.Parse(dr["SupplierId"].ToString());
                        rdetail.ProductId = Int32.Parse(dr["ProductId"].ToString());
                        rdetail.Quantity = Int32.Parse(dr["Quantity"].ToString());
                        rdetail.UnitPrice = Decimal.Parse(dr["UnitPrice"].ToString());
                        rdetail.TotalPricePro = Decimal.Parse(dr["TotalPricePro"].ToString());
                        listReceiptdetail.Add(rdetail);
                //    }
                //}
            }

            return listReceiptdetail;
        }

    }
}
