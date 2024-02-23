using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class PetDAO
    {
        private SqlDataAccessHelper _helper;
        public PetDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public bool AddPet(int? customerId, string name, int? breedId, DateTime? birthDate, int? age, string gender)
        {
            string query = "INSERT INTO Pets (CustomerID, Name, BreedID, BirthDate, Age, Gender) VALUES (@CustomerId, @Name, @BreedId, @BirthDate, @Age, @Gender)";
            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId ?? (object)DBNull.Value },
                new SqlParameter("@Name", SqlDbType.NVarChar, 100) { Value = name ?? (object)DBNull.Value },
                new SqlParameter("@BreedId", SqlDbType.Int) { Value = breedId ?? (object)DBNull.Value },
                new SqlParameter("@BirthDate", SqlDbType.DateTime) { Value = birthDate ?? (object)DBNull.Value },
                new SqlParameter("@Age", SqlDbType.Int) { Value = (object)age ?? DBNull.Value },
                new SqlParameter("@Gender", SqlDbType.NVarChar, 10) { Value = gender ?? (object)DBNull.Value }
            };

            return _helper.ExecuteInsertQuery(query, parameters);
        }

        public bool DeletePetByCustomerId(int customerId)
        {
            string query = "DELETE FROM Pets WHERE CustomerID = @CustomerId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId }
            };
            return _helper.ExecuteInsertQuery(query, parameters);
        }

        public DataTable GetPetsByCustomerId(int customerId)
        {
            string query = @"
            SELECT p.*
            FROM Pets p 
            INNER JOIN Customers c ON p.CustomerID = c.CustomerID
            WHERE c.CustomerID = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", SqlDbType.Int) { Value = customerId }
            };

            return _helper.ExecuteSelectQuery(query, parameters);
        }
    }
}
