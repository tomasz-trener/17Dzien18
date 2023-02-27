using P05Sklep.Shared;

namespace P04Sklep.API.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceReponse<Product[]>> GetProductAsync();

        Task<ServiceReponse<Product[]>> SearchProduts(string text, int page, int pageSize);

        Task<ServiceReponse<Product>> UpdateProduct(Product product);

        Task<ServiceReponse<bool>> DeleteProductAsync(int id);

        Task<ServiceReponse<Product>> CreateProduct(Product product);


    }
}
