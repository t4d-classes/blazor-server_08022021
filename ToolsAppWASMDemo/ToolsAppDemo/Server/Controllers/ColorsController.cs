using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

using ToolsAppDemo.Shared;

namespace ToolsAppDemo.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ColorsController : ControllerBase
  {
    private static List<Color> colors = new List<Color>()
    {
      new Color() { Id=1, Name="red", HexCode="ff0000" },
      new Color() { Id=2, Name="green", HexCode="00ff00" },
      new Color() { Id=3, Name="blue", HexCode="0000ff" },
    };

    [HttpGet]
    public IActionResult All()
    {
      Thread.Sleep(2000);
      return Ok(colors);
    }

    [HttpGet("{colorId:long}")]
    public IActionResult One(long colorId)
    {
      var color = colors.Find(c => c.Id == colorId);

      Thread.Sleep(2000);

      if (color == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(color);
      }
    }

    [HttpPost]
    public IActionResult Append([FromBody] Color color)
    {
      if (!ModelState.IsValid) return BadRequest();

      color.Id = colors.Max(c => c.Id) + 1;
      colors.Add(color);

      return Ok(color);
    }
  }
}
