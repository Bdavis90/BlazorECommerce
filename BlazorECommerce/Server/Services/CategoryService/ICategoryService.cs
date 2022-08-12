using BlazorECommerce.Shared;

namespace BlazorECommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
    }
}
