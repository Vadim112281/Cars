using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class AboutUsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}