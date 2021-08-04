using System.ComponentModel.DataAnnotations.Schema;

namespace ToolsApp.DataAccess.Models
{
  [Table("Color")]
  public class Color
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Hexcode { get; set; }
  }
}
