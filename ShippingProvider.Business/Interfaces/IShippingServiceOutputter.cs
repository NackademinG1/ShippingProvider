using ShippingProvider.Business.Models;

namespace ShippingProvider.Business.Interfaces
{
    public interface IShippingServiceOutputter
    {
        string JSONFormat(List<ShippingOption> shippingOptions);
        string HTMLFormat(List<ShippingOption> shippingOptions);
    }
}