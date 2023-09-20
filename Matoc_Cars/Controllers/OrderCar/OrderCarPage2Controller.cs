using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
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
        Static.modelcar = car.ModelOfCar.ToString();
        Static.yearcar = car.YearOfCar;

        if (Static.modelcar == "7")
        {
            
            return RedirectToAction("Index", "OrderCarPageMerceG");
        }

        return RedirectToAction("Index", "Home");


    }
    
}