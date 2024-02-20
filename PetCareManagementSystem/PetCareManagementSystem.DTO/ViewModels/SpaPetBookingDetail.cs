using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.ViewModels
{
    public class SpaPetBookingDetail
    {
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int EmployeeID { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public string ServiceName { get; set; }
        public decimal TotalPrice { get; set; }
        public string EmployeeName { get; set; }
        public string PetName { get; set; }
        public string BreedName { get; set; }
        public string SpeciesName { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string TypeName { get; set; }

        public string PetInformation
        {
            get
            {
                return $"{SpeciesName} ({BreedName})";
            }
        }
    }
}
