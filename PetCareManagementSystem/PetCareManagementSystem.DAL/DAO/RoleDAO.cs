using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DAL.DAO
{
    public class RoleDAO
    {
        private SqlDataAccessHelper _helper;

        public RoleDAO()
        {
            _helper = new SqlDataAccessHelper();
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM Roles";
            return _helper.ExecuteSelectAllQuery(query);
        }
    }
}
