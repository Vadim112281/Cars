using Matoc_Cars.Models;
using Matoc_Cars.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class OrderCarPageMerceGController : Controller
{
    private readonly IMercGService _GService;

    public OrderCarPageMerceGController(IMercGService gService)
    {
        _GService = gService;
    }

    // GET
    public IActionResult Index()
    {
        int year = Static.yearcar;
        var cars = _GService.GetByYear(year);
        
        return View(cars);

    }
}