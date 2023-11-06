using Matoc_Cars.Services.OrderedCarByUser;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.OrderedCarsByUser;

public class OrderedCarsByUserController : Controller
{
    private readonly IOrderedByUser _OrderedCarByUser;

    public OrderedCarsByUserController(IOrderedByUser orderedCarByUser)
    {
        _OrderedCarByUser = orderedCarByUser;
    }

    // GET
    public IActionResult Index()
    {
        var cars = _OrderedCarByUser.OrderedCarByUser(User.Identity.Name);
        
        return View(cars);
    }
}