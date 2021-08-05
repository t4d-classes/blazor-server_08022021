using System.ComponentModel.DataAnnotations;
using ToolsAppDemo.Client.Validators;

namespace ToolsAppDemo.Client.ViewModels
{
  public class CarForm
  {
    [Required]
    public string Make { get; set; }
    public string Model { get; set; }
    [Required]
    [MinCarYear]
    public int Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
  }
}