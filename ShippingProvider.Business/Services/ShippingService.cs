using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingProvider.Business.Interfaces;
using ShippingProvider.Business.Models;
using Newtonsoft.Json;

namespace ShippingProvider.Business.Services
{
    public class ShippingService : IShippingService
    {
        private List<ShippingCompany> shippingPartners = [];
        public List<ShippingOption> shippingOptions = [];
        private readonly ApiHandler apiHandler = new();
        
        public ShippingOption GetOneShippingOption()
        {
            throw new NotImplementedException();
        }

        public List<ShippingOption> GetShippingOptions()
        {
            throw new NotImplementedException();
        }

        public ResponseResult GetOffers(int cartWeight)
        {
            List<ResponseResult> apiResults = [];

            foreach(ShippingCompany company in shippingPartners)
            {
                apiResults.Add(apiHandler.CallApi(company.ApiKey, company.ApiUrl, cartWeight.ToString()));
            }

            //Convert entries in Apiresults content from json where success == true then add to shippingOptions

            throw new NotImplementedException();
        }
    }
}
