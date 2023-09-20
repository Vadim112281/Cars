using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class Add_Car : Controller
{
    private readonly IMercGService _service;

    public Add_Car(IMercGService service)
    {
        _service = service;
    }

    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(G_Class car)
    {
        _service.Add(car);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Delete(int id)
    {
        var car  =_service.GetById(id);

        _service.Delete(car);

        return Ok();
    }
}