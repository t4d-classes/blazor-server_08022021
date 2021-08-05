using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarsController : ControllerBase
  {
    private static List<Car> cars = new List<Car>()
    {
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

    [HttpGet]
    public IActionResult All()
    {
      return Ok(cars);
    }

    [HttpGet("{carId:long}")]
    public IActionResult One(long carId)
    {
      var car = cars.Find(c => c.Id == carId);

      if (car == null) {
        return NotFound();
      } else {
        return Ok(car);
      }
    }

    [HttpPost]
    public IActionResult Append([FromBody] Car car)
    {
      if (!ModelState.IsValid) return BadRequest();

      car.Id = cars.Max(c => c.Id) + 1;
      cars.Add(car);

      return Ok(car);
    }

    [HttpPut("{carId:long}")]
    public IActionResult Replace(long carId, [FromBody] Car car)
    {
      if (carId < 1 || car == null || carId != car.Id)
      {
        return BadRequest();
      }

      if (!ModelState.IsValid)
      {
        return BadRequest();
      }

      var carIndex = cars.FindIndex(c => c.Id == carId);
      cars[carIndex] = car;

      return Ok(car);
    }

    [HttpDelete("{carId:long}")]
    public IActionResult Remove(long carId)
    {
      var car = cars.Find(c => c.Id == carId);
      
      if (car == null) {
        return NotFound();
      } else {
        cars.Remove(car);
        return Ok(car);

      }
   }

  }
}
