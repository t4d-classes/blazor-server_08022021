using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolsAppDemo.Shared;
using ToolsAppDemo.Client.Interfaces;

namespace ToolsAppDemo.Client.Services
{
  public class ColorsInMemoryDataService: IColorsDataService
  {
    private List<Color> colors = new List<Color>()
    {
      new Color() { Id=1, Name="red", HexCode="ff0000" },
      new Color() { Id=2, Name="green", HexCode="00ff00" },
      new Color() { Id=3, Name="blue", HexCode="0000ff" },
    };

    public Task<IEnumerable<Color>> All()
    {
      return Task.FromResult(colors.AsEnumerable());
    }

    public Task<Color> One(long colorId)
    {
      return Task.FromResult(colors.Find(c => c.Id == colorId));
    }

    public Task<Color> AddColor(Color color)
    {
      color.Id = colors.Max(c => c.Id) + 1;
      colors.Add(color);

      return Task.FromResult(color);
    }
  }
}
