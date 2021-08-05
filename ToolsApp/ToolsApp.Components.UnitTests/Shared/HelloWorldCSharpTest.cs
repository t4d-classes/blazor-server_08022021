using Xunit;
using Bunit;

using ToolsApp.Components.Shared;

namespace ToolsApp.Components.UnitTests.Shared
{
  public class HelloWorldCSharpTest
  {
    [Fact]
    public void HelloWorldComponentRendersCorrectly()
    {
      // Arrange
      using (var ctx = new TestContext())
      {
        // Act
        var cut = ctx.RenderComponent<HelloWorld>();

        // Assert
        cut.MarkupMatches(@"
          <header>
            <h1>Hello, World!</h1>
          </header>
        ");
      }
    }
  }
}
