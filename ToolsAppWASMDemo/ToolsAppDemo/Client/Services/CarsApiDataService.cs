using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using ToolsAppDemo.Client.Interfaces;
using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Client.Services
{
  public class CarsApiDataService : ICarsDataService
  {
    private HttpClient _httpClient;

    public CarsApiDataService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public async Task<IEnumerable<Car>> All()
    {
      return await _httpClient.GetFromJsonAsync<Car[]>("/api/cars");
    }

    public async Task<Car> One(long carId)
    {
      return await _httpClient.GetFromJsonAsync<Car>(
        $"/api/cars/{Uri.EscapeUriString(carId.ToString())}");
    }

    public async Task<Car> AddCar(Car car)
    {
      var httpResponseMessage = await _httpClient.PostAsJsonAsync("/api/cars", car);

      return await httpResponseMessage.Content.ReadFromJsonAsync<Car>();
    }

    public async Task<Car> SaveCar(Car car)
    {
      var httpResponseMessage = await _httpClient.PutAsJsonAsync(
        $"/api/cars/{Uri.EscapeUriString(car.Id.ToString())}", car);

      return await httpResponseMessage.Content.ReadFromJsonAsync<Car>();
    }

    public async Task<Car> DeleteCar(long carId)
    {
      var car = await One(carId);

      await _httpClient.DeleteAsync(
        $"/api/cars/{Uri.EscapeUriString(carId.ToString())}");

      return car;
    }

  }
}
