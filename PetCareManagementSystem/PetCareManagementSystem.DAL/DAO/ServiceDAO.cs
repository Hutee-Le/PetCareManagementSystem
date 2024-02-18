using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class ServiceDAO
    {
        private SqlDataAccessHelper _helper;

        public ServiceDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public DataTable GetServicesByTypeName(string typeName)
        {
            string query = @"
                SELECT s.ServiceID, s.ServiceName, s.Description, s.Price, s.Promotion
                FROM Services s
                JOIN ServiceTypes st ON s.ServiceTypeID = st.ServiceTypeID
                WHERE st.TypeName = @TypeName";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TypeName", SqlDbType.NVarChar) {Value = typeName}
            };

            return _helper.ExecuteSelectQuery(query, parameters);
        }
    }
}
