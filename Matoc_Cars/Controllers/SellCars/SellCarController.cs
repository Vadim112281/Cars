using Matoc_Cars.Models.SellCar;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.SellCars;

public class SellCarController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(SellCarModel NameOfCar)
    {
        SellCarStatic.NameOfCar = NameOfCar.NameOfCar.ToString();

        return RedirectToAction("Index", "SellCarAllPage");
    }
}