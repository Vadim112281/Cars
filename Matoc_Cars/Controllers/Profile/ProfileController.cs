using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.Profile;

public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}