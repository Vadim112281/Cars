using Matoc_Cars.Models.CarSale;
using Matoc_Cars.Models.SellCar;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.CarForSell;

public class CategoryCarForSellController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(SaledCar car)
    {
        SaledCarStatic.NameOfCar = car.NameOfCar.ToString();

        return RedirectToAction("Index", "CategoryCarForSell_Page_2");
    }
}