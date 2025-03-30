using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class EnviosController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}