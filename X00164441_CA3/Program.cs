using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using X00164441_CA3;
using X00164441_CA3.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddHttpClient<IGogoAnimeClient, GogoAnimeClient>(client =>
{
    client.BaseAddress = new Uri(GogoAnimeConstants.BaseAddress);
});

await builder.Build().RunAsync();
