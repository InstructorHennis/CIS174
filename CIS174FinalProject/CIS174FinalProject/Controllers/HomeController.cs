using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CIS174FinalProject.Models;
using CIS174FinalProject.Filters;

namespace CIS174FinalProject.Controllers;

public class HomeController : Controller
{
    [PopulateBooksFilter]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
