using P05Sklep.Shared;
using P07Blazor.Client.ViewModels.Product;

namespace P07Blazor.Client.Services.ProductService
{
    public interface IProductService
    {
      //  Product[] ProductsCache { get; set; }

        List<ProductVM> ProductsVM { get; set; }
        ProductVM FindProduct(int id);

        Task EditProduct(ProductVM productVM);
        Task CreateProduct(ProductVM productVM);

        Task DeleteProduct(int id);

        Task GetProducts();
        event Action ProductsChanged;
        Task SearchProducts(string text, int page, int pageSize);
    }
}
