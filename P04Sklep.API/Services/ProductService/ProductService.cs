using Microsoft.EntityFrameworkCore;
using P04Sklep.API.Data;
using P05Sklep.Shared;
using P06Sklep.DataSeeder;

namespace P04Sklep.API.Services.ProductService
{
    
    public class ProductService : IProductService
    {

        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceReponse<Product>> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return new ServiceReponse<Product>() { Data = product };
        }

        public async Task<ServiceReponse<bool>> DeleteProductAsync(int id)
        {
            // Opcja 1: najpierw pobieramy ten ktory chcemy usunac 
            // potem go usuwamy 
            // ta opcja powoduje, ze 2 razy odwolujemy sie do bazy
            //var productToDelete = _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            //_context.Remove(productToDelete);
            //_context.SaveChangesAsync();

            // Opcja 2: (tutaj tylko jedno zapytanie do bazy) 
            var product = new Product() { Id = id };
            _context.Products.Attach(product);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            
            return new ServiceReponse<bool>() { Data = true };
        }

        public async Task<ServiceReponse<Product[]>> GetProductAsync()
        {
            var response = new ServiceReponse<Product[]>()
            {
                Data = await _context.Products 
                .Include(x=>x.MaterialCategory)
                .Include(x=>x.Product_ProductAdjectives)
                .ThenInclude(x=>x.ProductAdjective)  
                .ToArrayAsync()
            };

            return response;

            // odwołanie do DataContext (baza danych) 
            //var data = new Product[2]
            //{
            //    new Product()
            //    {
            //        Id =1,
            //        Title="Product 1",
            //        Description = "Desc 1",
            //    }, new Product()
            //    {
            //        Id =2,
            //        Title="Product 2",
            //        Description = "Desc 2",
            //    }
            //};


            //var response = new ServiceReponse<Product[]>()
            //{
            //    Data = ProductSeeder.GenerateProductData()
            //};
            //return response;


        }

        public async Task<ServiceReponse<Product[]>> SearchProduts(string text, int page, int pageSize)
        {
            var data = await _context.Products
                 .Include(x => x.MaterialCategory)
                 .Include(x => x.Product_ProductAdjectives)
                 .ThenInclude(x => x.ProductAdjective)
                 .Where(x=>
                    x.Title.Contains(text) ||
                    x.Description.Contains(text)
                    )
                 .Skip(pageSize*(page-1))
                 .Take(pageSize)
                 .ToArrayAsync();

            var response = new ServiceReponse<Product[]>()
            {
                Data = data
            };

            return response;
        }

        public async Task<ServiceReponse<Product>> UpdateProduct(Product product)
        {
            var p = _context.Products.FirstOrDefault(x=>x.Id == product.Id);

            if (p == null)
            {
                return new ServiceReponse<Product>
                {
                    Success = false,
                    Message = "Not found product"
                };
            }

            p.Title = product.Title;
            p.Description = product.Description;
            p.Color = product.Color;
            p.ImageUrl = product.ImageUrl;

            await _context.SaveChangesAsync();

            return new ServiceReponse<Product>() { Data = product };

        }
    }
}
