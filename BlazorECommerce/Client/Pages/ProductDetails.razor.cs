using BlazorECommerce.Client.Services;
using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorECommerce.Client.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public int? Id { get; set; }
        private Product product = null;
        [Inject]
        public IProductService ProductService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //if(ProductService is null || ProductService.Products.Count == 0)
            //{
            //    ProductService.LoadProducts();
            //}

            product = await ProductService.GetProduct((int)Id);
            //return base.OnInitializedAsync();
        }
    }
}
