using DemoApp.DataAccess.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DemoApp.DataAccess
{
  public static class DataAccessExtensions
  {

    public static void AddDemoAppDataAccess(this IServiceCollection services)
    {
      services.AddScoped<WeatherForecastService>();
      services.AddScoped<ColorsService>();
      services.AddScoped<UsersService>();
    }
  }
}
