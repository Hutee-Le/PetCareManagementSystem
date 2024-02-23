using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class SpeciesDAO
    {
        private SqlDataAccessHelper sqlDataAccessHelper;

        public SpeciesDAO()
        {
            sqlDataAccessHelper = new SqlDataAccessHelper();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Species";
            return sqlDataAccessHelper.ExecuteSelectAllQuery(query);
        }
    }
}
