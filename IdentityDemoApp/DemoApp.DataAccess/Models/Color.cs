using Microsoft.AspNetCore.Identity;
using AutoMapper.Configuration.Annotations;



namespace DemoApp.DataAccess.Models
{
  public class Color
  {
    public long Id { get; set; }
    public string UserId { get; set; }
    [Ignore]
    public IdentityUser User { get; set; }
    public string Name { get; set; }
    public string Hexcode { get; set; }

  }
}
