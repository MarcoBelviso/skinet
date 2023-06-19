using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
     public static async Task SeedAsync(StoreContext context)
     {
        if(!context.ProductBrands.Any())
        {
            var brandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
            var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
            context.ProductBrands.AddRange(brands);
        }

        if(!context.ProductTypes.Any())
        {
            var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
            var types = JsonSerializer.Deserialize<List<ProductBrand>>(typesData);
            context.ProductBrands.AddRange(types);
        }
        if(!context.Products.Any())
        {
            var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
            var products = JsonSerializer.Deserialize<List<ProductBrand>>(productsData);
            context.ProductBrands.AddRange(products);
        }

        if(context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
     }   
    }
}