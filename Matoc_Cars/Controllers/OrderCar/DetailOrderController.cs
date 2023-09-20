using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class DetailOrderController : Controller
{
    private readonly IMercGService _GService;
    private readonly IOrderedCar _OrderService;

    public DetailOrderController(IMercGService gService, IOrderedCar OrderService)
    {
        _GService = gService;
        _OrderService = OrderService;
    }

    // GET
    public IActionResult Index(int id)
    {
        var car = _GService.GetById(id);
        
        return View(car);
    }

    public IActionResult OrderCar(G_Class car)
    {
        return Ok();
    }
}