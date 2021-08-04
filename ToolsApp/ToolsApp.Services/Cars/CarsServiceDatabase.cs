using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsApp.DataAccess;
using ToolsApp.Models.Cars;

namespace ToolsApp.Services.Cars
{
  public class CarsServiceDatabase : ICarsService
  {
    private CarsData _carsData;

    public CarsServiceDatabase(CarsData carsData)
    {
      _carsData = carsData;
    }

    public Task<IEnumerable<Car>> All()
    {
      return _carsData.All();
    }

    public async Task<ICarsService> Append(NewCar car)
    {
      await _carsData.Append(car);

      return this;
    }

    public async Task<ICarsService> Remove(int carId)
    {
      await _carsData.Remove(carId);
      return this;
    }

    public async Task<ICarsService> Replace(Car car)
    {
      await _carsData.Replace(car);
      return this;
    }
  }
}
