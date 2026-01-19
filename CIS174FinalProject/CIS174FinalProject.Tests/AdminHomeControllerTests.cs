using CIS174FinalProject.Areas.Admin.Controllers;
using CIS174FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;

namespace CIS174FinalProject.Tests;

[TestClass]
public class AdminHomeControllerTests
{
    [TestMethod]
    public void AdminHomeController_HasAuthorizeAttribute()
    {
        // Arrange
        var controllerType = typeof(HomeController);

        // Act
        var authorizeAttribute = controllerType.GetCustomAttribute<AuthorizeAttribute>();

        // Assert
        Assert.IsNotNull(authorizeAttribute, "Admin HomeController should have [Authorize] attribute");
    }

    [TestMethod]
    public void AdminHomeController_HasAreaAttribute()
    {
        // Arrange
        var controllerType = typeof(HomeController);

        // Act
        var areaAttribute = controllerType.GetCustomAttribute<AreaAttribute>();

        // Assert
        Assert.IsNotNull(areaAttribute, "Admin HomeController should have [Area] attribute");
        Assert.AreEqual("Admin", areaAttribute.RouteValue, "Area should be 'Admin'");
    }

    [TestMethod]
    public void Index_ReturnsViewResult()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "AdminTestLibrary_Index")
            .Options;

        using var context = new LibraryContext(options);
        var controller = new HomeController(context);

        // Act
        var result = controller.Index();

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Delete_Get_WithValidId_ReturnsViewWithBook()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "AdminTestLibrary_Delete_Get")
            .Options;

        using (var context = new LibraryContext(options))
        {
            context.Authors.Add(new Author { Id = 1, FirstName = "Test", LastName = "Author" });
            context.Genres.Add(new Genre { Id = 1, Description = "Test Genre" });
            context.Books.Add(new Book 
            { 
                ISBN = "123-456-789", 
                Title = "Test Book", 
                AuthorId = 1, 
                GenreId = 1, 
                Year = 2024 
            });
            context.SaveChanges();
        }

        using (var context = new LibraryContext(options))
        {
            var controller = new HomeController(context);

            // Act
            var result = controller.Delete("123-456-789") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(Book));
            var book = result.Model as Book;
            Assert.AreEqual("Test Book", book?.Title);
        }
    }

    [TestMethod]
    public void Delete_Get_WithInvalidId_ReturnsNotFound()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "AdminTestLibrary_Delete_InvalidId")
            .Options;

        using var context = new LibraryContext(options);
        var controller = new HomeController(context);

        // Act
        var result = controller.Delete("999-999-999");

        // Assert
        Assert.IsInstanceOfType(result, typeof(NotFoundResult));
    }

    [TestMethod]
    public void DeleteConfirmed_WithValidId_RemovesBookAndRedirects()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "AdminTestLibrary_DeleteConfirmed")
            .Options;

        using (var context = new LibraryContext(options))
        {
            context.Authors.Add(new Author { Id = 1, FirstName = "Test", LastName = "Author" });
            context.Genres.Add(new Genre { Id = 1, Description = "Test Genre" });
            context.Books.Add(new Book 
            { 
                ISBN = "123-456-789", 
                Title = "Test Book", 
                AuthorId = 1, 
                GenreId = 1, 
                Year = 2024 
            });
            context.SaveChanges();
        }

        using (var context = new LibraryContext(options))
        {
            var controller = new HomeController(context);

            // Act
            var result = controller.DeleteConfirmed("123-456-789") as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ActionName);
        }

        // Verify book was deleted
        using (var context = new LibraryContext(options))
        {
            var book = context.Books.Find("123-456-789");
            Assert.IsNull(book, "Book should have been deleted");
        }
    }
}
