using PetCareManagementSystem.DAL.DAO;
using PetCareManagementSystem.DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.BLL
{
    public class RoomBookingBUS
    {
        private RoomBookingDAO _dao;

        public RoomBookingBUS()
        {
            _dao = new RoomBookingDAO();
        }

        public List<SpaPetBookingDetail> GetAllSpaPetBookings()
        {
            DataTable dtBookings = _dao.GetAllSpaPetBookings();
            List< SpaPetBookingDetail> listBookings = new List<SpaPetBookingDetail>();

            foreach (DataRow row in dtBookings.Rows)
            {
                listBookings.Add(new SpaPetBookingDetail
                {
                    BookingID = Convert.ToInt32(row["BookingID"]),
                    CustomerName = row["Name"].ToString(),
                    Date = Convert.ToDateTime(row["Date"]),
                    ServiceName = row["ServiceName"].ToString(),
                    TotalPrice = Convert.ToDecimal(row["TotalPrice"]),
                    EmployeeName = row["EmployeesName"].ToString(),
                    PetName = row["PetsName"].ToString(),
                    BreedName = row["BreedName"].ToString(),
                    SpeciesName = row["SpeciesName"].ToString(),
                    Status = row["Status"].ToString(),
                    PaymentStatus = row["PaymentStatus"].ToString(),
                    TypeName = row["TypeName"].ToString(),
                });
            }

            return listBookings;
        }
    }
}
