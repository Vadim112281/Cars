using System.IO.Enumeration;
using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.ProcesOfOrder;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class DetailOrderController : Controller
{
    private readonly IFindHaveCar _HaveForOrderCarService;

    public DetailOrderController(IFindHaveCar haveForOrderCarService)
    {
        _HaveForOrderCarService = haveForOrderCarService;
    }

    // GET
    public IActionResult Index(int id)
    {
        var car = _HaveForOrderCarService.GetById(id);
        
        return View(car);
    }


}