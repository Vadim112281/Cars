using Matoc_Cars.Models.SellCar;
using Matoc_Cars.Services.SellCars;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers.SellCars;

public class SellCarAllPageController : Controller
{
    private readonly ISellCar _SellService;

    public SellCarAllPageController(ISellCar sellService)
    {
        _SellService = sellService;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(SellCarModel model)
    {
        SellCarModel SellCar = new SellCarModel()
        {
            NameOfCar = model.NameOfCar,
            ModelOfCar = model.ModelOfCar,
            Year = model.Year,
            Engine = model.Engine,
            Transmission = model.Transmission,
            Color = model.Color,
            DriveUnit = model.DriveUnit,
            Price = model.Price,
            Description = model.Description,
            Mileage = model.Mileage,
            User = User.Identity.Name
        };

        _SellService.Add(SellCar);

        return RedirectToAction("Index", "Home");
    }
}