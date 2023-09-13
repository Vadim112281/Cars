using Matoc_Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class OrderCarPage2Controller : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ModelYearCar car)
    {
        Static.modelcar = car.ModelOfCar;
        Static.yearcar = car.YearOfCar;

        return RedirectToAction("Index", "Home");
    }
    
}