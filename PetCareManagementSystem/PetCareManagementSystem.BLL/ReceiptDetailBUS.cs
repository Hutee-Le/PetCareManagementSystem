using PetCareManagementSystem.DAL.DAO;
using System;
using System.Collections.Generic;
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
    }
}
