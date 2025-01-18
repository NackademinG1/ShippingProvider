using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Interfaces
{
    public interface ICartService
    {
        int GetTotalCartWeight();
        decimal GetCartCost();
    }
}
