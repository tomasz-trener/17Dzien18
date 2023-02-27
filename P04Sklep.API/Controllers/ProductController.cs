using Microsoft.AspNetCore.Mvc;
using P04Sklep.API.Services.ProductService;
using P05Sklep.Shared;

namespace P04Sklep.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<ServiceReponse<Product[]>>> GetProducts()
        {
            var result = await _productService.GetProductAsync();

            // var resultList = new ServiceReponse<List<Product>>();
            // resultList.Data = await result.Data.ToList();
            //if (result.Data[0].Product_ProductAdjectives != null)
            //{
            //    int dataProductActivityCount = result.Data[0].Product_ProductAdjectives.Count();
            //    Console.WriteLine("log count:" + dataProductActivityCount);
            //}
           
            return Ok(result);
            //  ProductService productService = new ProductService();
        }

        [HttpGet("search/{text}/{page}/{pageSize}")]
        public async Task<ActionResult<ServiceReponse<Product[]>>> GetSearchProducts(string text, int page = 1, int pageSize = 5)
        {
            var result = await _productService.SearchProduts(text, page, pageSize);

            return Ok(result);
            //  ProductService productService = new ProductService();
        }




        [HttpPut]
        public async Task<ActionResult<ServiceReponse<Product>>> UpdateProduct(Product product)
        {
            var results = await _productService.UpdateProduct(product);
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceReponse<Product>>> CreateProduct([FromBody] Product product)
        {
            var result = await _productService.CreateProduct(product);
            return Ok(result);
        }


        // https://localhost:7140/api/product/4
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceReponse<bool>>> DeleteProduct([FromRoute] int id)
        {
            var result = await _productService.DeleteProductAsync(id);
            return Ok(result);
        }
    }
}
