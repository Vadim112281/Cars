using Matoc_Cars.Models;
using Matoc_Cars.Services.ProcesOfOrder;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class OrderCarPageMerceGController : Controller
{
    private readonly IFindHaveCar _FindHaveService;

    public OrderCarPageMerceGController(IFindHaveCar findHaveService)
    {
        _FindHaveService = findHaveService;
    }

    // GET
    public IActionResult Index()
    {
        IEnumerable<HaveCarForOrder> cars = _FindHaveService.FindCarByName(Static.modelcar, Static.yearcar);

        return View(cars);
    }
    
    
}