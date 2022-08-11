using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Services
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
