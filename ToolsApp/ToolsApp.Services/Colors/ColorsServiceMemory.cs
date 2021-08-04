using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsApp.Models.Colors;

namespace ToolsApp.Services.Colors
{
  public class ColorsServiceMemory : IColorsService
  {
    private List<Color> _colors = new();

    public Task<IEnumerable<Color>> All()
    {
      return Task.FromResult<IEnumerable<Color>>(_colors);
    }

    public Task<IColorsService> Append(NewColor color)
    {
      var newColorId = _colors.Any()
        ? _colors.Max(c => c.Id) + 1 : 1;

      _colors.Add(
        new(
          newColorId,
          color.Name,
          color.Hexcode
        )
      );

      return Task.FromResult<IColorsService>(this);
    }

    public Task<IColorsService> Remove(int colorId)
    {
      _colors.Remove(_colors.Find(c => c.Id == colorId));
      return Task.FromResult<IColorsService>(this);
    }

    public Task<IColorsService> Replace(Color color)
    {
      int colorIndex = _colors.FindIndex(c => c.Id == color.Id);
      _colors[colorIndex] = color;
      return Task.FromResult<IColorsService>(this);
    }
  }
}
