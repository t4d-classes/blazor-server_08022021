using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsAppDemo.Shared;
using ToolsAppDemo.Client.Interfaces;

namespace ToolsAppDemo.Client.Services
{
  public class CarsInMemoryDataService: ICarsDataService
  {

    private List<Car> cars = new List<Car>() {
      new Car() {
        Id=1, Make="Ford",
        Model="Fusion Hybrid", Year=2020,
        Color="red", Price=45000
      },
      new Car() {
        Id=2, Make="Tesla",
        Model="S", Year=2019,
        Color="blue", Price=120000
      },
    };

    public Task<IEnumerable<Car>> All()
    {
      return Task.FromResult(cars.AsEnumerable());
    }

    public Task<Car> One(long carId)
    {
      return Task.FromResult(cars.Find(c => c.Id == carId));
    }

    public Task<Car> AddCar(Car car) {
      car.Id = cars.Max(c => c.Id) + 1;
      cars.Add(car);
      return Task.FromResult(car);
    }

    public Task<Car> SaveCar(Car car)
    {
      var carIndex = cars.FindIndex(c => c.Id == car.Id);
      cars[carIndex] = car;
      return Task.FromResult(car);
    }

    public Task<Car> DeleteCar(long carId)
    {
      var car = cars.Find(c => c.Id == carId);
      cars.Remove(car);
      return Task.FromResult(car);
    }

  }
}
