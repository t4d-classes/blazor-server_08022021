using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Client.Interfaces
{
  public interface ICarsDataService
  {
    Task<IEnumerable<Car>> All();
    Task<Car> One(long carId);
    Task<Car> AddCar(Car car);
    Task<Car> SaveCar(Car car);
    Task<Car> DeleteCar(long carId);
  }
}
