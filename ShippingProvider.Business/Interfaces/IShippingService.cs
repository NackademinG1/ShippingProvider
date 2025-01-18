using ShippingProvider.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Interfaces
{
    public interface IShippingService
    {
        
        decimal CalculateShipping(int weight);
        List<ShippingOption> GetShippingOptions();

        ShippingOption GetOneShippingOption();
        
    }
}
