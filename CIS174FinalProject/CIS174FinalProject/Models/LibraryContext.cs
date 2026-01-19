using Microsoft.EntityFrameworkCore;

namespace CIS174FinalProject.Models;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed Genres
        modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Description = "Fiction" },
            new Genre { Id = 2, Description = "Science Fiction" },
            new Genre { Id = 3, Description = "Classic Literature" },
            new Genre { Id = 4, Description = "Fantasy" },
            new Genre { Id = 5, Description = "Dystopian" }
        );

        // Seed Authors
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, FirstName = "Harper", LastName = "Lee" },
            new Author { Id = 2, FirstName = "George", LastName = "Orwell" },
            new Author { Id = 3, FirstName = "F. Scott", LastName = "Fitzgerald" },
            new Author { Id = 4, FirstName = "J.K.", LastName = "Rowling" },
            new Author { Id = 5, FirstName = "J.R.R.", LastName = "Tolkien" },
            new Author { Id = 6, FirstName = "Jane", LastName = "Austen" },
            new Author { Id = 7, FirstName = "Herman", LastName = "Melville" },
            new Author { Id = 8, FirstName = "Leo", LastName = "Tolstoy" },
            new Author { Id = 9, FirstName = "Charles", LastName = "Dickens" },
            new Author { Id = 10, FirstName = "Mark", LastName = "Twain" }
        );

        // Seed 10 famous books
        modelBuilder.Entity<Book>().HasData(
            new Book 
            { 
                ISBN = "978-0-06-112008-4", 
                AuthorId = 1, 
                Title = "To Kill a Mockingbird", 
                Year = 1960, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-452-28423-4", 
                AuthorId = 2, 
                Title = "1984", 
                Year = 1949, 
                GenreId = 5 
            },
            new Book 
            { 
                ISBN = "978-0-7432-7356-5", 
                AuthorId = 3, 
                Title = "The Great Gatsby", 
                Year = 1925, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-439-13959-8", 
                AuthorId = 4, 
                Title = "Harry Potter and the Sorcerer's Stone", 
                Year = 1997, 
                GenreId = 4 
            },
            new Book 
            { 
                ISBN = "978-0-618-00222-1", 
                AuthorId = 5, 
                Title = "The Lord of the Rings", 
                Year = 1954, 
                GenreId = 4 
            },
            new Book 
            { 
                ISBN = "978-0-14-143951-8", 
                AuthorId = 6, 
                Title = "Pride and Prejudice", 
                Year = 1813, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-14-243724-7", 
                AuthorId = 7, 
                Title = "Moby-Dick", 
                Year = 1851, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-14-044793-4", 
                AuthorId = 8, 
                Title = "War and Peace", 
                Year = 1869, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-14-143974-7", 
                AuthorId = 9, 
                Title = "Great Expectations", 
                Year = 1861, 
                GenreId = 3 
            },
            new Book 
            { 
                ISBN = "978-0-14-039084-2", 
                AuthorId = 10, 
                Title = "The Adventures of Huckleberry Finn", 
                Year = 1884, 
                GenreId = 3 
            }
        );
    }
}
