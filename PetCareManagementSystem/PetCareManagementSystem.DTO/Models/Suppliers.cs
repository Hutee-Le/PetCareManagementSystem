using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Suppliers
    {
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string ContactName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; } = new List<ReceiptDetail>();
    }
}
