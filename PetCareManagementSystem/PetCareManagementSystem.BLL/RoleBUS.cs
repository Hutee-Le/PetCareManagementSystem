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
    public class RoleBUS
    {
        private RoleDAO _roleDao;

        public RoleBUS()
        {
            _roleDao = new RoleDAO();
        }

        public List<Roles> GetAll()
        {
            DataTable dtRole = _roleDao.GetAll();
            List<Roles> listRoles = new List<Roles>();

            foreach(DataRow dr in dtRole.Rows)
            {
                listRoles.Add(new Roles()
                {
                    RoleId = Convert.ToInt32(dr["RoleID"]),
                    RoleName = Convert.ToString(dr["RoleName"]),
                });
            }
            return listRoles;
        }
    }
}
