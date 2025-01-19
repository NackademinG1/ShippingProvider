using ShippingProvider.Business.Interfaces;
using ShippingProvider.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Services
{
    public class ShippingServiceOutputter : IShippingServiceOutputter
    {
        public string HTMLFormat(List<ShippingOption> shippingOptions)
        {
            throw new NotImplementedException();
        }

        public string JSONFormat(List<ShippingOption> shippingOptions)
        {
            throw new NotImplementedException();
        }
    }
}
