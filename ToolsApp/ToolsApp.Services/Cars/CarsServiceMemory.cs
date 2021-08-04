using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ToolsApp.Models.Cars;

namespace ToolsApp.Services.Cars
{
  public class CarsServiceMemory : ICarsService
  {

    private List<Car> _cars = new();

    public Task<IEnumerable<Car>> All()
    {
      return Task.FromResult<IEnumerable<Car>>(_cars);
    }

    public Task<ICarsService> Append(NewCar car)
    {
      var newCarId = _cars.Any()
      ? _cars.Max(c => c.Id) + 1 : 1;

      _cars.Add(
        new(
          newCarId,
          car.Make,
          car.Model,
          car.Year,
          car.Color,
          car.Price
        )
      );

      return Task.FromResult<ICarsService>(this);
    }

    public Task<ICarsService> Remove(int carId)
    {
      _cars.Remove(_cars.Find(c => c.Id == carId));

      return Task.FromResult<ICarsService>(this);
    }

    public Task<ICarsService> Replace(Car car)
    {
      int carIndex = _cars.FindIndex(c => c.Id == car.Id);
      _cars[carIndex] = car;

      return Task.FromResult<ICarsService>(this);
    }
  }
}
