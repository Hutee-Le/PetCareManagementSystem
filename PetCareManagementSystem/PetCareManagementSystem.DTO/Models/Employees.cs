using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ImageUrl { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        public virtual ICollection<EmployeeRoles> EmployeeRoles { get; set; } = new List<EmployeeRoles>();

        public virtual ICollection<Receipt> Receipts { get; set; } = new List<Receipt>();

        public virtual ICollection<RoomBooking> RoomBookings { get; set; } = new List<RoomBooking>();
    }
}
