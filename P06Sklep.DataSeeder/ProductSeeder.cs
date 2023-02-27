using Bogus;
using P05Sklep.Shared;

namespace P06Sklep.DataSeeder
{
    public class ProductSeeder
    {
        private const int productCount = 30;
        private const int materialCategoryCount = 5;
        private const int productAdjectiveCount = 3;
        private const int product_ProductAdjectiveCount = 60;
        private const int maxProductPrice = 1000;

        public static Product[] GenerateProductData()
        {
            int productId = 1;
            var productFaker = new Faker<Product>("pl")
                .RuleFor(o => o.Title, f => f.Commerce.ProductName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductDescription())
                .RuleFor(o => o.Id, f => productId++)
                .RuleFor(o => o.Color, f => f.Commerce.Color())
                .RuleFor(o => o.ImageUrl, f=>f.Image.LoremFlickrUrl())
                .RuleFor(o => o.Premium, f=>f.Random.Bool())
                .RuleFor(o=> o.MaterialCategoryId, f=>f.Random.Number(1, materialCategoryCount))
                ;

            return productFaker.Generate(productCount).ToArray();
        }
        public static MaterialCategory[] GenerateMaterialCategory()
        {
            int categoryId = 1;
            var productFaker = new Faker<MaterialCategory>("pl")
                .RuleFor(o => o.Id, f => categoryId++)
                .RuleFor(o => o.Name, f => f.Commerce.ProductMaterial());
               // .RuleFor(o => o.Url, f => f.Commerce.ProductMaterial().Replace(" ","-"));
          
            var data = productFaker.Generate(materialCategoryCount).ToList();
            data.ForEach(x => x.Url = x.Name.Replace(" ", "-"));
            return data.ToArray();

        }

        public static ProductAdjective[] GenerateProductAdjective()
        {
            int id = 1;
            var productFaker = new Faker<ProductAdjective>("pl")
                .RuleFor(o => o.Id, f => id++)
                .RuleFor(o => o.Name, f => f.Commerce.ProductAdjective());

            return productFaker.Generate(productAdjectiveCount).ToArray();
        }

        public static Product_ProductAdjective[] GenerateProduct_ProductAdjective()
        {
            var productFaker = new Faker<Product_ProductAdjective>("pl")
                .RuleFor(o => o.Price, f => f.Random.Number(1, maxProductPrice))
                .RuleFor(o=> o.ProductId, f=>f.Random.Number(1, productCount))
                .RuleFor(o=> o.ProductAdjectiveId, f=>f.Random.Number(1, productAdjectiveCount));

            var data = productFaker.Generate(product_ProductAdjectiveCount).ToArray();

            data =data
                .GroupBy(x => new { x.ProductId, x.ProductAdjectiveId })
                .Select(x => x.FirstOrDefault())
                .ToArray();
            return data;
        }


    }
}