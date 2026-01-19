using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CIS174FinalProject.Models;
using CIS174FinalProject.Filters;

namespace CIS174FinalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class HomeController : Controller
{
    private readonly LibraryContext _context;

    public HomeController(LibraryContext context)
    {
        _context = context;
    }

    [PopulateBooksFilter]
    public IActionResult Index()
    {
        return View();
    }

    // GET: Admin/Home/Delete/5
    public IActionResult Delete(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var book = _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .FirstOrDefault(b => b.ISBN == id);
        
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    // POST: Admin/Home/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(string id)
    {
        var book = _context.Books.Find(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        
        return RedirectToAction("Index");
    }
}
