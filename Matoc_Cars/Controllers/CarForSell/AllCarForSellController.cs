using Matoc_Cars.Services.CarOnSale;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.CarForSell;

public class AllCarForSellController : Controller
{
    private readonly ICarSale _CarSaleService;

    public AllCarForSellController(ICarSale carSaleService)
    {
        _CarSaleService = carSaleService;
    }

    // GET
    public async Task<IActionResult> Index()
    {
        var cars = await _CarSaleService.GetAll();
        
        return View(cars);
    }
}