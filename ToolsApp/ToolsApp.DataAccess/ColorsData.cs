using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ColorDataModel = ToolsApp.DataAccess.Models.Color;
using ColorModel = ToolsApp.Models.Colors.Color;
using NewColorModel = ToolsApp.Models.Colors.NewColor;

namespace ToolsApp.DataAccess
{
  public class ColorsData
  {
    private ToolsAppContext _toolsAppContext;
    private IMapper _mapper;

    public ColorsData(ToolsAppContext toolsAppContext)
    {
      _toolsAppContext = toolsAppContext;

      var config = new MapperConfiguration(cfg => {
        cfg.CreateMap<ColorModel, ColorDataModel>().ReverseMap();
        cfg.CreateMap<NewColorModel, ColorDataModel>();
      });

      _mapper = config.CreateMapper();
    }

    public async Task<IEnumerable<ColorModel>> All()
    {
      return await _toolsAppContext.Colors
        .Select(color => _mapper.Map<ColorDataModel, ColorModel>(color))
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<ColorModel> Append(NewColorModel color)
    {
      var colorDataModel = _mapper.Map<NewColorModel, ColorDataModel>(color);

      await _toolsAppContext.AddAsync(colorDataModel);
      await _toolsAppContext.SaveChangesAsync();
      _toolsAppContext.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(colorDataModel);
    }

    public async Task<ColorModel> Replace(ColorModel color)
    {
      var oldColorDataModel = await _toolsAppContext.Colors
        .AsNoTracking()
        .FirstOrDefaultAsync(c => c.Id == color.Id);

      if (oldColorDataModel is null)
      {
        throw new NullReferenceException($"Unable to find color {color.Id}");
      }

      var colorDataModel = _mapper.Map<ColorModel, ColorDataModel>(color);

      _toolsAppContext.Update(colorDataModel);
      await _toolsAppContext.SaveChangesAsync();
      _toolsAppContext.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(oldColorDataModel);
    }

    public async Task<ColorModel> Remove(int colorId)
    {
      var colorDataModel = await _toolsAppContext.Colors.FindAsync(colorId);

      _toolsAppContext.Colors.Remove(colorDataModel);
      await _toolsAppContext.SaveChangesAsync();
      _toolsAppContext.ChangeTracker.Clear();

      return _mapper.Map<ColorDataModel, ColorModel>(colorDataModel);
    }
  }
}
