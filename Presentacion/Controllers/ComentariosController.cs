using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class ComentariosController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}