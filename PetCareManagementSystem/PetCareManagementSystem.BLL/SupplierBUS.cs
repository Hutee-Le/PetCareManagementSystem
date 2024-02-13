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
    public class SupplierBUS
    {
        private SupplierDAO supplierDAO;
        public SupplierBUS()
        {
            supplierDAO = new SupplierDAO();
        }
        public List<DTO.Models.Suppliers> getAll()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = supplierDAO.getAll();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);


            }
            List<Suppliers> listsup = new List<Suppliers>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Suppliers sup = new Suppliers();
                    sup.SupplierId = Int32.Parse(dr["SupplierId"].ToString());
                    sup.SupplierName = dr["SupplierName"].ToString();
                    sup.ContactName = dr["ContactName"].ToString();
                    sup.Address = dr["Address"].ToString();
                    sup.PhoneNumber = dr["PhoneNumber"].ToString();


                    listsup.Add(sup);
                }
            }


            return listsup;
        }
    }
}
