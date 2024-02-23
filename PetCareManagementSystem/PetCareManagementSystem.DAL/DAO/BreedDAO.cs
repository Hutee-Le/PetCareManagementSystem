using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class BreedDAO
    {
        private SqlDataAccessHelper sqlDataAccessHelper;

        public BreedDAO()
        {
            sqlDataAccessHelper = new SqlDataAccessHelper();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Breeds";
            return sqlDataAccessHelper.ExecuteSelectAllQuery(query);
        }

        public DataTable GetByBreedId(int speciesId)
        {
            string query = "SELECT * FROM Breeds WHERE SpeciesID = @SpeciesID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SpeciesID", speciesId)
            };

            return sqlDataAccessHelper.ExecuteSelectQuery(query, parameters);
        }
    }
}
