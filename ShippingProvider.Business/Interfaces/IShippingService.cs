﻿using ShippingProvider.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Interfaces
{
    public interface IShippingService
    {
        ShippingOption GetOneShippingOption();
        List<ShippingOption> GetShippingOptions();
        ResponseResult GetOffers(int cartWeight);
        

        
        
    }
}
