using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime ReceiptDate { get; set; }

        public decimal TotalAmount { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; } = new List<ReceiptDetail>();
    }
}
