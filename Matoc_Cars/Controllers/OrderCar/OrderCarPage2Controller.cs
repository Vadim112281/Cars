using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.ProcesOfOrder;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class OrderCarPage2Controller : Controller
{
    private readonly IFindHaveCar _FindHaveService;

    public OrderCarPage2Controller(IFindHaveCar findHaveService)
    {
        _FindHaveService = findHaveService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(HaveCarForOrder car)
    {
        Static.modelcar = car.ShortName;
        Static.yearcar = (int)car.YearOfCar;

        return RedirectToAction("Index", "OrderCarPageMerceG");


    }
    
}