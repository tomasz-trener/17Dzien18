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

        public Product[] Products { get; set; }
        public ProductVM[] ProductsVM { get; set; }

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceReponse<Product[]>>("api/product");

            Products = result.Data;

            ProductsVM = Products.Select(x => new ProductVM()
            {
                Id = x.Id,
                Description = x.Description,
                MaterialCategory = x.MaterialCategory?.Name,
                Title = x.Title,
                Adjectives = x.Product_ProductAdjectives?.Select(y => y.ProductAdjective.Name).ToArray()
            }).ToArray();

            ProductsChanged?.Invoke();
        }

        public async Task SearchProducts(string text, int page=1, int pageSize=5)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceReponse<Product[]>>($"api/product/search/{text}/{page}/{pageSize}");

            Products = result.Data;

            ProductsVM = Products.Select(x => new ProductVM()
            {
                Id = x.Id,
                Description = x.Description,
                MaterialCategory = x.MaterialCategory?.Name,
                Title = x.Title,
                Adjectives = x.Product_ProductAdjectives?.Select(y => y.ProductAdjective.Name).ToArray()
            }).ToArray();

            ProductsChanged?.Invoke();
        }
    }
}
