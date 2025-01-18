using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingProvider.Business.Models
{
    internal class ResponseResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = null!;
        public int statusCode { get; set; }
    }
}
