using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ToolsApp.Models.Cars;

namespace ToolsApp.Services.Cars
{
  public interface ICarsService
  {
    Task<IEnumerable<Car>> All();
    Task<ICarsService> Append(NewCar car);
    Task<ICarsService> Replace(Car car);
    Task<ICarsService> Remove(int carId);
  }
}
