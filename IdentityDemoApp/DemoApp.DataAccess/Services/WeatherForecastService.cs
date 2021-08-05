using System;
using System.Linq;
using System.Threading.Tasks;

using WeatherForecastModel = DemoApp.Models.WeatherForecast;

namespace DemoApp.DataAccess.Services
{
  public class WeatherForecastService
  {
    private static readonly string[] Summaries = new[]
    {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    public Task<WeatherForecastModel[]> GetForecastAsync(DateTime startDate)
    {
      var rng = new Random();
      return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
      {
        Date = startDate.AddDays(index),
        TemperatureC = rng.Next(-20, 55),
        Summary = Summaries[rng.Next(Summaries.Length)]
      }).ToArray());
    }
  }
}
