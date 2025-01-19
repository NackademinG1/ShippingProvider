using ShippingProvider.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Interfaces
{
    public interface IApiHandler
    {
        ResponseResult CallApi(string apiKey, string apiUrl, string apiParams);
    }
}
