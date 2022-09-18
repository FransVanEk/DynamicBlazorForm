using DynamicBlazorForm.Core;
using DynamicBlazorForm.Themes.HTML;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DynamicBlazorFormTestWebSite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped(sp =>
                        new DynamicElementsRepository()
                              .GetHTMLDefaultSettings()
                              .Add("TextInput",   typeof(TextInput))
                              .Add("NumberInput", typeof(NumberInput))
                              .Add("BoolInput", typeof(BoolInput))
                              .Add("DateInput", typeof(DynamicBlazorForm.Themes.RadzenForm.DateInput)));

            await builder.Build().RunAsync();
        }
    }
}