using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    public class ShippingOption
    {
        public string CompanyName { get; set; } = null!;
        public decimal ShippingCost { get; set; }
        public string ShippingType { get; set; } = null!;
        public string ExpectedArrival { get; set; } = null!;
    }
}
