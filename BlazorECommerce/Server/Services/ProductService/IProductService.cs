using BlazorECommerce.Shared;

namespace BlazorECommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProduct(int id);
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
    }
}
