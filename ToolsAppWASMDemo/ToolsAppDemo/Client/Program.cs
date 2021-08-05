using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using ToolsAppDemo.Client.Interfaces;
using ToolsAppDemo.Client.Services;

namespace ToolsAppDemo.Client
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
      });

      //builder.Services.AddScoped<IColorsDataService, ColorsInMemoryDataService>();
      builder.Services.AddScoped<IColorsDataService, ColorsApiDataService>();

      //builder.Services.AddScoped<ICarsDataService, CarsInMemoryDataService>();
      builder.Services.AddScoped<ICarsDataService, CarsApiDataService>();

      builder.Services.AddScoped<ScreenBlockerService>();

      await builder.Build().RunAsync();
    }
  }
}
