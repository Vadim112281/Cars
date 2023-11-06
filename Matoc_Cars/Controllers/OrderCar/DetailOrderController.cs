using System.IO.Enumeration;
using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.OrderCar;
using Matoc_Cars.Services.ProcesOfOrder;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class DetailOrderController : Controller
{
    private readonly IFindHaveCar _HaveForOrderCarService;
    private readonly IOrderCar _OrderService;

    public DetailOrderController(IFindHaveCar haveForOrderCarService, IOrderCar OrderService)
    {
        _HaveForOrderCarService = haveForOrderCarService;
        _OrderService = OrderService;
    }

    // GET
    public IActionResult Index(int id)
    {
        var car = _HaveForOrderCarService.GetById(id);
        
        return View(car);
    }

    public IActionResult OrderCar(int id)
    {
        var car = _HaveForOrderCarService.GetById(id);

        CarOrder OrderedCar = new CarOrder()
        {
            NameOfCar = car.NameOfCar,
            ModelOfCar = car.ModelOfCar,
            YearOfCar = car.YearOfCar,
            Color = car.Color,
            Price = car.Price,
            User = User.Identity.Name,
            ShortModelOfCar = car.ShortNameOfCar
        };

        _OrderService.OrderedCar(OrderedCar);

        return RedirectToAction("Index", "Home");
    }


}