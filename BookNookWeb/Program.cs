using BookNookWeb;
using BookNookWeb.Services;
using BookNookWeb.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7014/") });
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
await builder.Build().RunAsync();
