using Matoc_Cars.Models.CarSale;
using Matoc_Cars.Services.CarOnSale;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class CategoryCarForSell_Page_3Controller : Controller
{
    private readonly ICarSale _SaleService;

    public CategoryCarForSell_Page_3Controller(ICarSale saleService)
    {
        _SaleService = saleService;
    }


    // GET
    public IActionResult Index()
    {
        var car = new SaledCar()
        {
            NameOfCar = SaledCarStatic.NameOfCar,
            ModelOfCar = SaledCarStatic.ModelOfCar,
            YearOfCar = SaledCarStatic.YearOfCar,
            PriceUnder = SaledCarStatic.PriceUnder,
            PriceFrom = SaledCarStatic.PriceFrom
        };

       var cars =  _SaleService.GetByCategory(car);

        return View(cars);
    }
}