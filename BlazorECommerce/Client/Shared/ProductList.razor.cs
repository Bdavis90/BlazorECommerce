
using BlazorECommerce.Client.Services;
using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorECommerce.Client.Shared
{
    public partial class ProductList: IDisposable
    {
        [Inject]
        public IProductService ProductService { get; set; }


        //[Parameter]
        //public int? CategoryId { get; set; } = null;

        protected override void OnInitialized()
        {
            //await ProductService.LoadProducts();
            ProductService.OnChange += StateHasChanged;
        }
        public void Dispose()
        {
            ProductService.OnChange -= StateHasChanged;   
        }
    }
}
