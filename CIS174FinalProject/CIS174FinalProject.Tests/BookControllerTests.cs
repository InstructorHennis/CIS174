using CIS174FinalProject.Controllers;
using CIS174FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CIS174FinalProject.Tests;

[TestClass]
public class BookControllerTests
{
    [TestMethod]
    public void BookController_DoesNotHaveDeleteMethod()
    {
        // Arrange
        var controllerType = typeof(BookController);

        // Act
        var deleteMethod = controllerType.GetMethod("Delete", BindingFlags.Public | BindingFlags.Instance);

        // Assert
        Assert.IsNull(deleteMethod, "BookController should not have a Delete method");
    }

    [TestMethod]
    public void BookController_DoesNotHaveDeleteConfirmedMethod()
    {
        // Arrange
        var controllerType = typeof(BookController);

        // Act
        var deleteConfirmedMethod = controllerType.GetMethod("DeleteConfirmed", BindingFlags.Public | BindingFlags.Instance);

        // Assert
        Assert.IsNull(deleteConfirmedMethod, "BookController should not have a DeleteConfirmed method");
    }
}
