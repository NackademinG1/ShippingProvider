using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    internal class ShippingCompany
    {
        public string ApiUrl { get; private set; } = null!;
        public string CompanyName { get; set; } = null!;
        public List<ShippingTier> ShippingTiers { get; set; } = [];

        public int DeliveryTime { get; set; }

    }
}
