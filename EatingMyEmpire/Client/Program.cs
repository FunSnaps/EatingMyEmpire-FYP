using EatingMyEmpire.Client.Pages.Models;
using EatingMyEmpire.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            /*builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });*/
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44311/") });

            builder.Services.AddScoped<IRecipeService, RecipeService>();

            builder.Services.AddScoped<IRecipeStepService, RecipeStepService>();

            builder.Services.AddAutoMapper(typeof(RecipeProfile));

            await builder.Build().RunAsync();
        }
    }
}
