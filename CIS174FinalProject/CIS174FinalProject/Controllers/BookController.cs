using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CIS174FinalProject.Models;

namespace CIS174FinalProject.Controllers;

public class BookController : Controller
{
    private readonly LibraryContext _context;

    public BookController(LibraryContext context)
    {
        _context = context;
    }

    // GET: Book/Create
    public IActionResult Create()
    {
        PopulateDropdowns();
        ViewBag.IsEdit = false;
        return View("Edit", new Book() { Year = DateTime.Now.Year });
    }

    // POST: Book/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        
        PopulateDropdowns(book.AuthorId, book.GenreId);
        ViewBag.IsEdit = false;
        return View("Edit", book);
    }

    // GET: Book/Edit/5
    public IActionResult Edit(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = _context.Books.Find(id);
        if (book == null)
        {
            return NotFound();
        }

        PopulateDropdowns(book.AuthorId, book.GenreId);
        ViewBag.IsEdit = true;
        return View(book);
    }

    // POST: Book/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(string id, Book book)
    {
        if (id != book.ISBN)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(book);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(book.ISBN))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index", "Home");
        }
        
        PopulateDropdowns(book.AuthorId, book.GenreId);
        ViewBag.IsEdit = true;
        return View(book);
    }

    private bool BookExists(string isbn)
    {
        return _context.Books.Any(e => e.ISBN == isbn);
    }

    private void PopulateDropdowns(int? selectedAuthorId = null, int? selectedGenreId = null)
    {
        var authors = _context.Authors
            .OrderBy(a => a.LastName)
            .Select(a => new
            {
                Id = a.Id,
                FullName = a.FirstName + " " + a.LastName
            })
            .ToList();

        ViewBag.Authors = new SelectList(authors, "Id", "FullName", selectedAuthorId);
        ViewBag.Genres = new SelectList(_context.Genres.OrderBy(g => g.Description), "Id", "Description", selectedGenreId);
    }
}
