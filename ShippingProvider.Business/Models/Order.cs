using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    public class Order
    {
        public List<Product> Products { get; set; } = [];
        public string Customer { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public ShippingOption OrderShipping { get; set; } = null!;
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
