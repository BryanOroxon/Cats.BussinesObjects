using Cats.BussinesObjects.ValueObjects;
using Cats.IoC;
using Cats.WebBlazor.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddCoreServices(builder.Configuration.GetSection("CatsEndpoints").Get<CatsEndpoints>());

await builder.Build().RunAsync();
