﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingProvider.Business.Interfaces;
using ShippingProvider.Business.Models;

namespace ShippingProvider.Business.Services
{
    internal class CartService : ICartService
    {
        private Cart cart = new();
        public decimal GetCartCost()
        {
            throw new NotImplementedException();
        }

        public int GetTotalCartWeight()
        {
            throw new NotImplementedException();
        }
    }
}
