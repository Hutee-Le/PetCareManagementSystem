using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class ReceiptDetail
    {
        public int ReceiptDetailId { get; set; }

        public int ReceiptId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPricePro { get; set; }

        public int SupplierId { get; set; }

        public virtual Product Product { get; set; } 

        public virtual Receipt Receipt { get; set; }

        public virtual Suppliers Suppliers { get; set; }
    }
}
