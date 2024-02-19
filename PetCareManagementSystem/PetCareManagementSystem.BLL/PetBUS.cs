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
    public class PetBUS
    {
        private PetDAO _dao;
        public PetBUS()
        {
            _dao = new PetDAO();
        }
        public List<Pets> GetPetsByCustomerId(int customerId)
        {
            DataTable dtPets = _dao.GetPetsByCustomerId(customerId);
            List<Pets> listPets = new List<Pets>();

            foreach(DataRow dr in dtPets.Rows)
            {
                listPets.Add(new Pets()
                {
                    PetId = Convert.ToInt32(dr["PetID"]),
                    BreedId = Convert.ToInt32(dr["BreedID"]),
                    CustomerId = Convert.ToInt32(dr["CustomerID"]),
                    Name = dr["Name"].ToString(),
                    ImageUrl = dr["ImageUrl"].ToString(),
                    BirthDate = Convert.ToDateTime(dr["BirthDate"]),
                    Age = Convert.ToInt32(dr["Age"]),
                    Gender = dr["Gender"].ToString()
                });
            }
            return listPets;
        }
    }
}
