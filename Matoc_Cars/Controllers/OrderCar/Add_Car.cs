using Matoc_Cars.Models.Mercedes;

using Microsoft.AspNetCore.Mvc;

namespace Matoc_Cars.Controllers;

public class Add_Car : Controller
{


    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(G_Class car)
    {
   
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Delete(int id)
    {
        

        return Ok();
    }
}