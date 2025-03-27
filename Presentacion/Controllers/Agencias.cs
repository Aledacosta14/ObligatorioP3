using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class Agencias : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}