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

        private List<Product> productsCache { get; set; }
        public List<ProductVM> ProductsVM { get; set; }
       
        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceReponse<Product[]>>("api/product");

            productsCache = result.Data.ToList();

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

            }).ToList();

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

            var product = productsCache.First(x => x.Id == productVM.Id);
            product.Title = edited.Title;
            product.Description = edited.Description;

            product.Product_ProductAdjectives = null;
            var result= _httpClient.PutAsJsonAsync<Product>("api/product", product);
            ProductsChanged?.Invoke();
        }

        public async Task DeleteProduct(int id)
        {
            var deleted = productsCache.First(x => x.Id == id);

            var result = _httpClient.DeleteAsync($"api/product/{id}");
            productsCache.RemoveAll(x => x.Id == id);
            ProductsVM.RemoveAll(x => x.Id == id);
        }

        public async Task CreateProduct(ProductVM productVM)
        {
            Product newProduct = new Product();
            newProduct.Title = productVM.Title;
            newProduct.Description = productVM.Description;

            //dodajemy produkty do bazy 
            var result = await _httpClient.PostAsJsonAsync($"api/product", newProduct);

            var productData = await result.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
            
            var newAddedProdcut = productData.Data;

            //teraz dodajemy loklanie te produkty 
            productsCache.Insert(0, newAddedProdcut);
            
            // musimy zakutaluzowac nasza lolakną liste produktów
            var newAddedProductVM = ProductsVM.FirstOrDefault(x => x.Id == 0);
            newAddedProductVM.Id = newAddedProdcut.Id;
            newAddedProductVM.Title = productVM.Title;
            newAddedProductVM.Description = productVM.Description;
            ProductsChanged?.Invoke();
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
            }).ToList();

            ProductsChanged?.Invoke();
        }

       
    }
}
