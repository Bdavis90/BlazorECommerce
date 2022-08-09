using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Shared
{
    public partial class ProductList
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "The Htichiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99M,
                OriginalPrice = 19.99M
            },
            new Product
            {
                Id = 2,
                CategoryId = 3,
                Title = "Half-Life 2",
                Description = "Half-Life 2 is a 2004 first-person shooter game developed by Valve. It was published by Valve through its distribution service Steam. Like the original Half-Life (1998), Half-Life 2 combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                Price = 8.19M,
                OriginalPrice = 29.99M
            }
        };
    }
}
