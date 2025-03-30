using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class AgenciasController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}