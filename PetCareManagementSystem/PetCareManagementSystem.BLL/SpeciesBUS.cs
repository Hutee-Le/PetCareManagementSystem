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
    public class SpeciesBUS
    {
        private SpeciesDAO speciesDAO;

        public SpeciesBUS()
        {
            speciesDAO = new SpeciesDAO();
        }

        public List<Species> GetAll()
        {
            DataTable dt = speciesDAO.GetAll();
            List<Species> list = new List<Species>();
            
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new Species
                {
                    SpeciesId = Convert.ToInt32(dr["SpeciesID"]),
                    SpeciesName = Convert.ToString(dr["SpeciesName"]),
                });
            }

            return list;
        }
    }
}
