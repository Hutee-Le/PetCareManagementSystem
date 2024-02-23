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
    public class BreedBUS
    {
        private BreedDAO breedDAO;
        public BreedBUS()
        {
            breedDAO = new BreedDAO();
        }

        public List<Breeds> GetAll()
        {
            DataTable dt = breedDAO.GetAll();
            List<Breeds> breeds = new List<Breeds>();
            foreach (DataRow dr in dt.Rows)
            {
                breeds.Add(new Breeds()
                {
                    BreedId = Convert.ToInt32(dr["BreedID"]),
                    SpeciesId = Convert.ToInt32(dr["SpeciesID"]),
                    BreedName = dr["BreedName"].ToString()
                });
            }
            return breeds;

        }

        public List<Breeds> GetByBreedId(int speciesId)
        {
            DataTable dt = breedDAO.GetByBreedId(speciesId);
            List<Breeds> breeds = new List<Breeds>();
            foreach(DataRow dr in dt.Rows)
            {
                breeds.Add(new Breeds()
                {
                    BreedId = Convert.ToInt32(dr["BreedID"]),
                    SpeciesId = Convert.ToInt32(dr["SpeciesID"]),
                    BreedName = dr["BreedName"].ToString()
                });
            }
            return breeds;
        }
    }
}
