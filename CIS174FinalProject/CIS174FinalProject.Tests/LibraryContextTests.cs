using Microsoft.EntityFrameworkCore;
using CIS174FinalProject.Models;

namespace CIS174FinalProject.Tests;

[TestClass]
public class LibraryContextTests
{
    [TestMethod]
    public void LibraryContext_CanBeCreated()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<LibraryContext>()
            .UseInMemoryDatabase(databaseName: "TestLibrary")
            .Options;

        // Act
        using var context = new LibraryContext(options);

        // Assert
        Assert.IsNotNull(context);
        Assert.IsNotNull(context.Books);
        Assert.IsNotNull(context.Authors);
        Assert.IsNotNull(context.Genres);
    }

    [TestMethod]
    public void Book_HasCorrectProperties()
    {
        // Arrange
        var book = new Book
        {
            ISBN = "978-0-06-112008-4",
            AuthorId = 1,
            Title = "To Kill a Mockingbird",
            Year = 1960,
            GenreId = 1
        };

        // Assert
        Assert.AreEqual("978-0-06-112008-4", book.ISBN);
        Assert.AreEqual(1, book.AuthorId);
        Assert.AreEqual("To Kill a Mockingbird", book.Title);
        Assert.AreEqual(1960, book.Year);
        Assert.AreEqual(1, book.GenreId);
    }

    [TestMethod]
    public void Author_HasCorrectProperties()
    {
        // Arrange
        var author = new Author
        {
            Id = 1,
            FirstName = "Harper",
            LastName = "Lee"
        };

        // Assert
        Assert.AreEqual(1, author.Id);
        Assert.AreEqual("Harper", author.FirstName);
        Assert.AreEqual("Lee", author.LastName);
    }

    [TestMethod]
    public void Genre_HasCorrectProperties()
    {
        // Arrange
        var genre = new Genre
        {
            Id = 1,
            Description = "Fiction"
        };

        // Assert
        Assert.AreEqual(1, genre.Id);
        Assert.AreEqual("Fiction", genre.Description);
    }
}
