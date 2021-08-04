using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ToolsApp.DataAccess;
using ToolsApp.Models.Colors;

namespace ToolsApp.Services.Colors
{
  public class ColorsServiceDatabase: IColorsService
  {
    private ColorsData _colorsData;

    public ColorsServiceDatabase(ColorsData colorsData)
    {
      _colorsData = colorsData;
    }

    public async Task<IEnumerable<Color>> All()
    {
      return await _colorsData.All();
    }

    public async Task<IColorsService> Append(NewColor color)
    {
      await _colorsData.Append(color);

      return this;
    }

    public async Task<IColorsService> Remove(int colorId)
    {
      await _colorsData.Remove(colorId);

      return this;
    }

    public async Task<IColorsService> Replace(Color color)
    {
      await _colorsData.Replace(color);

      return this;
    }
  }
}
