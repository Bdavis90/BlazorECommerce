using BlazorECommerce.Shared;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient http;

        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }

        public async Task LoadCategoriesAsync()
        {
            Categories = await http.GetFromJsonAsync<List<Category>>("Category");
        }
    }
}
