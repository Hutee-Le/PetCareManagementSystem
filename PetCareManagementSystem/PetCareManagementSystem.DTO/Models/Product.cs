using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareManagementSystem.DTO.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public int CateProId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }

        public int QuantityInStock { get; set; }

        public string Image { get; set; }

        public virtual CategoryProduct CatePro { get; set; }

        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; } = new List<ReceiptDetail>();
    }
}
