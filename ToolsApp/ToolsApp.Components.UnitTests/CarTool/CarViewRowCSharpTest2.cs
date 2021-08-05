using System;
using Xunit;
using Bunit;
using Moq;

using ToolsApp.Components.CarTool;
using ToolsApp.Models.Cars;

namespace ToolsApp.Components.UnitTests.CarTool
{
  public class CarViewRowCSharpTest2: TestContext
  {
    private Car _car = new(
      1,
      "Ford",
      "Fusion Hybrid",
      2020,
      "blue",
      45000.0M);

    [Fact]
    public void CarViewRowEditButtonOutput()
    {
      // Arrange
      var editCarActionMock = Mock.Of<Action<int>>();

      // Act
      var cut = RenderComponent<CarViewRow>(parameters => parameters
        .Add(p => p.Car, _car)
        .Add(p => p.OnEditCar, editCarActionMock));

      var editCarButtonElement = cut.Find("td:nth-child(7) button:first-child");

      editCarButtonElement.Click();

      // Assert
      Mock.Get(editCarActionMock).Verify(mock => mock(1), Times.Once());
    }

    [Fact]
    public void CarViewRowDeleteButtonOutput()
    {
      // Arrange
      var deleteCarActionMock = Mock.Of<Action<int>>();

      // Act
      var cut = RenderComponent<CarViewRow>(parameters => parameters
        .Add(p => p.Car, _car)
        .Add(p => p.OnDeleteCar, deleteCarActionMock));

      var deleteCarButtonElement = cut.Find("td:nth-child(7) button:last-child");

      deleteCarButtonElement.Click();

      // Assert
      Mock.Get(deleteCarActionMock).Verify(mock => mock(1), Times.Once());
    }

  }
}
