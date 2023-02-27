using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using P03AplikacjaPogodaClientAPI.Models.CityModel;
using P05Sklep.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P03AplikacjaPogodaClientAPI.Tools
{
    internal class ProductsApiTool
    {
        private string _baseURl;
        public ProductsApiTool()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<App>();
            //.SetBasePath(Directory.GetCurrentDirectory()) // odwołanie do pliku konfiguracyjnego 
            // .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            _baseURl = configuration["products_base_url"];
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseURl);
                var result = await client.PutAsJsonAsync("api/product",product);

                var resultMessage = await result.Content.ReadAsStringAsync(); // w ten sposób możemy odczytać błąd, który leci z API

                var content =await result.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
                return content.Data;
            }
        }

        public async Task<Product[]> GetProducts()
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(_baseURl);
            //    var result = await client.GetFromJsonAsync <ServiceReponse<Product[]>>("api/product");

            //    return result.Data;
            //}


            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(_baseURl + "/api/product");
                string json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<ServiceReponse<Product[]>>(json);

                return result.Data;
            }

        }

        internal async Task<bool> DeleteProduct(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseURl);
                await client.DeleteAsync($"/api/product/{id}");
                return true;
            }

        }

        internal async Task<Product> CreateProduct(Product productToCreate)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseURl);
                var result = await client.PostAsJsonAsync("api/product", productToCreate);

                var resultMessage = await result.Content.ReadAsStringAsync(); // w ten sposób możemy odczytać błąd, który leci z API


                var content = await result.Content.ReadFromJsonAsync<ServiceReponse<Product>>();
                return content.Data;
            }
        }
    }
}
