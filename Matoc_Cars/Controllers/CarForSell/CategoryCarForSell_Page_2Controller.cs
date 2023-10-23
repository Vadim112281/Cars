using Matoc_Cars.Models.CarSale;
using Matoc_Cars.Services.CarOnSale;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.CarForSell;

public class CategoryCarForSell_Page_2Controller : Controller
{
    private readonly ICarSale _SaleService;

    public CategoryCarForSell_Page_2Controller(ICarSale saleService)
    {
        _SaleService = saleService;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(SaledCar model)
    {
        SaledCarStatic.ModelOfCar = model.ModelOfCar;
        SaledCarStatic.YearOfCar = model.YearOfCar;
        SaledCarStatic.PriceFrom = model.PriceFrom;
        SaledCarStatic.PriceUnder = model.PriceUnder;

        return RedirectToAction("Index", "CategoryCarForSell_Page_3");
    }
}