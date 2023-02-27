﻿using P05Sklep.Shared;
using P07Blazor.Client.ViewModels.Product;

namespace P07Blazor.Client.Services.ProductService
{
    public interface IProductService
    {
        Product[] Products { get; set; }

        ProductVM[] ProductsVM { get; set; }

        Task GetProducts();
        event Action ProductsChanged;
        Task SearchProducts(string text, int page, int pageSize);
    }
}