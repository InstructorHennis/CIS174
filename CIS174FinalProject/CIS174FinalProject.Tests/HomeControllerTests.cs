using Microsoft.AspNetCore.Mvc;
using CIS174FinalProject.Controllers;

namespace CIS174FinalProject.Tests;

[TestClass]
public class HomeControllerTests
{
    [TestMethod]
    public void Index_ReturnsViewResult()
    {
        // Arrange
        var controller = new HomeController();

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
}
