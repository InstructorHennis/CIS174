using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using CIS174FinalProject.Models;

namespace CIS174FinalProject.Filters;

/// <summary>
/// Action filter that populates the ViewBag with a list of books including Author and Genre information.
/// This filter reduces code duplication across controllers that need to display book lists.
/// </summary>
public class PopulateBooksFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var controller = context.Controller as Controller;
        if (controller != null)
        {
            var dbContext = context.HttpContext.RequestServices.GetRequiredService<LibraryContext>();
            var books = dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .ToList();
            
            controller.ViewBag.Books = books;
        }
        
        base.OnActionExecuting(context);
    }
}
