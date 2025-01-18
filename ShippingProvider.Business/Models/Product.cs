using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    internal class Product
    {
        public string Id { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; private set; }
        public int productWeight { get; set; } 
    }
}
