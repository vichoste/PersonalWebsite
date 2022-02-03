#region Header
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Website;
#endregion
#region Builder
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazorise(options => options.ChangeTextOnKeyPress = true).AddBootstrap5Components().AddBootstrap5Providers().AddFontAwesomeIcons();

builder.Services.AddLocalization();

await builder.Build().RunAsync();
#endregion