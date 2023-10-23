using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.CarForSell;

public class CarForSellController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}