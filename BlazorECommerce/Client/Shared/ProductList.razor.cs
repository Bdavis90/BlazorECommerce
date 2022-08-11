using BlazorECommerce.Client.Services;
using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorECommerce.Client.Shared
{
    public partial class ProductList
    {
        [Inject]
        public IProductService ProductService { get; set; }

        protected async override Task OnInitializedAsync()
        {
           ProductService.LoadProducts();
        }
    }
}
