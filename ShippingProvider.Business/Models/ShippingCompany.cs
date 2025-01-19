using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    public class ShippingCompany
    {
        public string ApiUrl { get; set; } = null!;
        public string ApiKey { get; set; } = null!;
        public string CompanyName { get; set; } = null!;

    }
}
