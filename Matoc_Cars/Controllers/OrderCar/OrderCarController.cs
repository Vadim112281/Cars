using Matoc_Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class OrderCarController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(NameCar car)
    {
        Static.namecar = car.NameOfCar.ToString();
        
        return RedirectToAction("Index", "OrderCarPage2");
    }
}