using Microsoft.AspNetCore.Mvc;
using CIS174FinalProject.Models;

namespace CIS174FinalProject.Controllers;

public class AuthorController : Controller
{
    private readonly LibraryContext _context;

    public AuthorController(LibraryContext context)
    {
        _context = context;
    }

    // GET: Author/Create
    public IActionResult Create(string? returnUrl)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View();
    }

    // POST: Author/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Author author, string? returnUrl)
    {
        if (ModelState.IsValid)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            
            if (!string.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            
            return RedirectToAction("Index", "Home");
        }
        
        ViewBag.ReturnUrl = returnUrl;
        return View(author);
    }
}
