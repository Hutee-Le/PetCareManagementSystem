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
    public class ReceiptBUS
    {
        private ReceiptDAO receiptDAO;
        public ReceiptBUS()
        {
            receiptDAO = new ReceiptDAO();
        }
        public List<DTO.Models.Receipt> getAll()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = receiptDAO.getAll();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Receipt> listReceipt = new List<Receipt>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Receipt receipt = new Receipt();
                    receipt.ReceiptId = Int32.Parse(dr["ReceiptId"].ToString());
                    receipt.ReceiptDate = DateTime.Parse(dr["ReceiptDate"].ToString());
                    receipt.TotalAmount = Decimal.Parse(dr["TotalAmount"].ToString());


                    listReceipt.Add(receipt);
                }
            }


            return listReceipt;
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
        public List<DTO.Models.Receipt> GetReceiptAnalisys()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = receiptDAO.GetReceiptAnalisys();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Receipt> listReceipt = new List<Receipt>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Receipt receipt = new Receipt();
                    receipt.ReceiptId = Int32.Parse(dr["ReceiptId"].ToString());
                    receipt.ReceiptDate = DateTime.Parse(dr["ReceiptDate"].ToString());
                    receipt.TotalAmount = Decimal.Parse(dr["TotalAmount"].ToString());


                    listReceipt.Add(receipt);
                }
            }


            return listReceipt;
        }

        public List<DTO.Models.Receipt> GetReceiptbymonth()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = receiptDAO.GetReceiptbymonth();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Receipt> listReceipt = new List<Receipt>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Receipt receipt = new Receipt();
                    receipt.ReceiptId = Int32.Parse(dr["ReceiptId"].ToString());
                    receipt.ReceiptDate = DateTime.Parse(dr["ReceiptDate"].ToString());
                    receipt.TotalAmount = Decimal.Parse(dr["TotalAmount"].ToString());


                    listReceipt.Add(receipt);
                }
            }


            return listReceipt;
        }

        public List<DTO.Models.Receipt> GetReceiptToday()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = receiptDAO.GetReceiptToday();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Receipt> listReceipt = new List<Receipt>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Receipt receipt = new Receipt();
                    receipt.ReceiptId = Int32.Parse(dr["ReceiptId"].ToString());
                    receipt.ReceiptDate = DateTime.Parse(dr["ReceiptDate"].ToString());
                    receipt.TotalAmount = Decimal.Parse(dr["TotalAmount"].ToString());


                    listReceipt.Add(receipt);
                }
            }


            return listReceipt;
        }
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                bool insertionSuccess = receiptDAO.LoadData(startDate, endDate);

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public string countSumReceipt()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                string insertionSuccess = receiptDAO.countSumReceipt();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "-1";
            }
        }
        public int countPro1month()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = receiptDAO.countPro1month();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public string countReceipt1month()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                string insertionSuccess = receiptDAO.countReceipt1month();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "-1";
            }
        }

        public int countProToday()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = receiptDAO.countProToday();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int countPro7days()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                int insertionSuccess = receiptDAO.countPro7days();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public string countReceipt7days()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                string insertionSuccess = receiptDAO.countReceipt7days();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "-1";
            }
        }
        
              public string countReceiptToday()
        {
            try
            {
                // Call AddStudent in the DAO to insert the new student
                string insertionSuccess = receiptDAO.countReceiptToday();

                return insertionSuccess;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "-1";
            }
        }
    }
}
