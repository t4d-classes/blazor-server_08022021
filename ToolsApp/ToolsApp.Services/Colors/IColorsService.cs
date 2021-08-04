using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ToolsApp.Models.Colors;

namespace ToolsApp.Services.Colors
{
  public interface IColorsService
  {
    Task<IEnumerable<Color>> All();
    Task<IColorsService> Append(NewColor color);
    Task<IColorsService> Replace(Color color);
    Task<IColorsService> Remove(int colorId);
  }
}
