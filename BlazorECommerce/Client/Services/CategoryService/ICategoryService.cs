using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        public Task LoadCategoriesAsync();
    }
}
