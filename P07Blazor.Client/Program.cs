using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using P07Blazor.Client;
using P07Blazor.Client.Services.ProductService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string baseAdress= builder.Configuration.GetSection("ApiUrl").Value;
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAdress) });
builder.Services.AddScoped<IProductService, ProductService>();


await builder.Build().RunAsync();
