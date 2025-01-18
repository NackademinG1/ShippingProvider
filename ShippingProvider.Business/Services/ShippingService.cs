using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingProvider.Business.Interfaces;
using ShippingProvider.Business.Models;

namespace ShippingProvider.Business.Services
{
    public class ShippingService : IShippingService
    {
        private List<ShippingCompany> shippingOffers = [];
        public decimal CalculateShipping(int weight)
        {
            throw new NotImplementedException();
        }

        public ShippingOption GetOneShippingOption()
        {
            throw new NotImplementedException();
        }

        public List<ShippingOption> GetShippingOptions()
        {
            throw new NotImplementedException();
        }
    }
}
