using System;
using System.Collections.Generic;

using Xunit;
using Bunit;
using Moq;

using ToolsApp.Components.Shared;

namespace ToolsApp.Components.UnitTests.Shared
{
  public class ActionDataListCSharpTest : TestContext
  {
    [Fact]
    public void ActionDataListComponentActionButtonClicked()
    {
      // Arrange
      List<string> colors = new()
      {
        "red",
        "green",
        "blue"
      };
      string emptyMessage = "No Colors";

      var actionButtonLabel = "X";

      var itemActionMock = Mock.Of<Action<string>>();

      // Act
      var cut = RenderComponent<ActionDataList>(parameters =>
        parameters
          .Add(p => p.Items, colors)
          .Add(p => p.EmptyMessage, emptyMessage)
          .Add(p => p.ActionButtonLabel, actionButtonLabel)
          .Add(p => p.OnItemAction, itemActionMock)
          .AddChildContent("<h3>Colors</h3>"));

      var buttonElement = cut.Find("li:nth-child(2) button");

      buttonElement.Click();

      // Assert
      Mock.Get(itemActionMock).Verify(mock => mock("green"), Times.Once());
    }
  }
}
