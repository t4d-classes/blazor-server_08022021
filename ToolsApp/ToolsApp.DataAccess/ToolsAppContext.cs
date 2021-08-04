using Microsoft.EntityFrameworkCore;
using ToolsApp.DataAccess.Models;

namespace ToolsApp.DataAccess
{
  public class ToolsAppContext: DbContext
  {
    public ToolsAppContext(DbContextOptions<ToolsAppContext> options)
      : base(options)
    { }

    public DbSet<Color> Colors { get; set; }
  }
}
