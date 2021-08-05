using Xunit;
using Bunit;

using ToolsApp.Components.Shared;

namespace ToolsApp.Components.UnitTests.Shared
{
  public class ToolHeaderCSharpTest
  {
    [Fact]
    public void ToolHeaderComponentRendersCorrectly()
    {
      // Arrange
      using (var ctx = new TestContext())
      {
        // Act
        var cut = ctx.RenderComponent<ToolHeader>(parameters => {
        
          parameters.Add(p => p.HeaderText, "The Tool");

        });

        // Assert
        cut.MarkupMatches(@"
          <header>
            <h3>The Tool</h3>
          </header>
        ");
      }
    }
  }
}
