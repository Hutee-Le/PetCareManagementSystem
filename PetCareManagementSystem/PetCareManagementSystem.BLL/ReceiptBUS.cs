using PetCareManagementSystem.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class ReceiptBUS
    {
        private ReceiptDAO receiptDAO;
        public ReceiptBUS()
        {
            receiptDAO = new ReceiptDAO();
        }
        public int AddReceipt(int EmployeeID, DateTime ReceiptDate, decimal TotalAmount)
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = receiptDAO.AddReceipt(EmployeeID, ReceiptDate, TotalAmount);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public int getIDReceipt()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = receiptDAO.getIDReceipt();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
