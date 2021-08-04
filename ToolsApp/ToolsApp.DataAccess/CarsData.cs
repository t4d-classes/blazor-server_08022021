using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDataModel = ToolsApp.DataAccess.Models.Car;
using NewCarModel = ToolsApp.Models.Cars.NewCar;
using CarModel = ToolsApp.Models.Cars.Car;

namespace ToolsApp.DataAccess
{
  public class CarsData
  {
    private ToolsAppContext _toolAppsContext;
    private IMapper _mapper;

    public CarsData(ToolsAppContext toolAppsContext)
    {
      _toolAppsContext = toolAppsContext;

      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<CarModel, CarDataModel>().ReverseMap();
        cfg.CreateMap<NewCarModel, CarDataModel>();
      });

      _mapper = config.CreateMapper();
    }

    public async Task<IEnumerable<CarModel>> All()
    {
      return await _toolAppsContext.Cars
        .Select(car => _mapper.Map<CarDataModel, CarModel>(car))
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<CarModel> Append(NewCarModel car)
    {
      var carDataModel = _mapper.Map<NewCarModel, CarDataModel>(car);

      await _toolAppsContext.AddAsync(carDataModel);
      await _toolAppsContext.SaveChangesAsync();
      _toolAppsContext.ChangeTracker.Clear();


      return _mapper.Map<CarDataModel, CarModel>(carDataModel);
    }

    public async Task<CarModel> Replace(CarModel car)
    {
      var oldCarDataModel = await _toolAppsContext.Cars
        .AsNoTracking()
        .FirstOrDefaultAsync(c => c.Id == car.Id);

      if (oldCarDataModel is null)
      {
        throw new NullReferenceException("Unable to find car.");
      }

      var carDataModel = _mapper.Map<CarModel, CarDataModel>(car);

      _toolAppsContext.Update(carDataModel);
      await _toolAppsContext.SaveChangesAsync();
      _toolAppsContext.ChangeTracker.Clear();

      return _mapper.Map<CarDataModel, CarModel>(oldCarDataModel);
    }

    public async Task<CarModel> Remove(int carId)
    {
      var carDataModel = await _toolAppsContext.Cars.FindAsync(carId);

      _toolAppsContext.Cars.Remove(carDataModel);
      await _toolAppsContext.SaveChangesAsync();
      _toolAppsContext.ChangeTracker.Clear();

      return _mapper.Map<CarDataModel, CarModel>(carDataModel);
    }
  }
}
