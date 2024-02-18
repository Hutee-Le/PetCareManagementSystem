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
    public class ServiceBUS
    {
        private ServiceDAO _dao;

        public ServiceBUS()
        {
            _dao = new ServiceDAO();
        }

        public List<Service> GetServicesByTypeName(string typeName)
        {
            DataTable dtServices = _dao.GetServicesByTypeName(typeName);
            List<Service> listServices = new List<Service>();

            foreach (DataRow row in dtServices.Rows)
            {
                listServices.Add(new Service()
                {
                    ServiceId = Convert.ToInt32(row["ServiceID"]),
                    ServiceName = row["ServiceName"].ToString(),
                    Description = row["Description"].ToString(),
                    Price = Convert.ToDecimal(row["Price"]),
                    Promotion = Convert.ToDecimal(row["Promotion"]),
                });
            }
            return listServices;
        }
    }
}
