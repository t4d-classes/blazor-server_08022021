using System.ComponentModel.DataAnnotations;
using ToolsAppDemo.Client.Validators;


namespace ToolsAppDemo.Client.ViewModels
{
  public class ColorForm
  {
    [Required]
    public string Name { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(3)]
    [HexColor(3)]
    public string HexCode { get; set; }
  }
}
