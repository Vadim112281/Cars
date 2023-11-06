using Matoc_Cars.Services.CarOnSale;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.CarForSell;

public class ForSaleDetailController : Controller
{
    private readonly ICarSale _CarSaleService;

    public ForSaleDetailController(ICarSale carSaleService)
    {
        _CarSaleService = carSaleService;
    }

    // GET
    public IActionResult Index(int id)
    {
        var CarForSale =  _CarSaleService.GetCarById(id);
        
        return View(CarForSale);
    }
}