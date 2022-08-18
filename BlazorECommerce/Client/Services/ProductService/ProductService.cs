using BlazorECommerce.Shared;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient http;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService(HttpClient http)
        {
            this.http = http;
        }
        public async Task LoadProducts(string categoryUrl = null)
        {
            Products = await http.GetFromJsonAsync<List<Product>>($"Product/{categoryUrl}");
            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await http.GetFromJsonAsync<Product>($"Product/{id}");
        }
    }
}
