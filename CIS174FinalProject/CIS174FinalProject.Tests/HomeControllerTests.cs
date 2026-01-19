using CIS174FinalProject.Controllers;
using CIS174FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174FinalProject.Tests;

[TestClass]
public class HomeControllerTests
{
    [TestMethod]
    public void Index_ReturnsViewResult()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "TestLibrary")
            .Options;

        // Act
        using var context = new LibraryContext(options);
        var controller = new HomeController(context);

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
}
