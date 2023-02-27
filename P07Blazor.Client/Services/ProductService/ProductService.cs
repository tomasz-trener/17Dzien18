using P05Sklep.Shared;
using P07Blazor.Client.ViewModels.Product;
using System.Net.Http.Json;

namespace P07Blazor.Client.Services.ProductService
{
    public class ProductService : IProductService
    {

        private HttpClient _httpClient;

        public event Action ProductsChanged; 

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

       // public Product[] Products { get; set; }
        public ProductVM[] ProductsVM { get; set; }
       
        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceReponse<Product[]>>("api/product");

          //  Products = result.Data;

            ProductsVM = result.Data.Select(x => new ProductVM()
            {
                Id = x.Id,
                Description = x.Description,
                MaterialCategory = x.MaterialCategory?.Name,
                Title = x.Title,
                Adjectives = x.Product_ProductAdjectives?.Select(y => y.ProductAdjective.Name).ToArray(),
                PriceFrom = x.Product_ProductAdjectives?.Min(y=>y?.Price),
                PriceTo = x.Product_ProductAdjectives?.Max(y => y?.Price),
                ImageUrl = x.ImageUrl

            }).ToArray();

            ProductsChanged?.Invoke();
        }

        public ProductVM FindProduct(int id)
        {
            return ProductsVM.FirstOrDefault(x => x.Id == id);
        }

        public async Task EditProduct(ProductVM productVM)
        {
            var edited= ProductsVM.FirstOrDefault(x => x.Id == productVM.Id);
            edited.Title = productVM.Title;
            edited.Description = productVM.Description;

            var product = new Product();
            var result= _httpClient.PutAsJsonAsync<Product>("api/product", product);


            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(_baseURl);
            //    var result = await client.PutAsJsonAsync("api/product", product);

            //    var resultMessage = await result.Content.ReadAsStringAsync(); // w ten sposób możemy odczytać błąd, który leci z API

            //    var content = await result.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
            //    return content.Data;
            //}

        }

        public async Task SearchProducts(string text, int page=1, int pageSize=5)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceReponse<Product[]>>($"api/product/search/{text}/{page}/{pageSize}");

         //   Products = result.Data;

            ProductsVM = result.Data.Select(x => new ProductVM()
            {
                Id = x.Id,
                Description = x.Description,
                MaterialCategory = x.MaterialCategory?.Name,
                Title = x.Title,
                Adjectives = x.Product_ProductAdjectives?.Select(y => y.ProductAdjective.Name).ToArray(),
                PriceFrom = x.Product_ProductAdjectives?.Min(y => y?.Price),
                PriceTo = x.Product_ProductAdjectives?.Max(y => y?.Price)
            }).ToArray();

            ProductsChanged?.Invoke();
        }

      
    }
}
