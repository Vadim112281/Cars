using Matoc_Cars.Areas.Identity.Data;

namespace Matoc_Cars.Models;

public class CarOrder
{
    public int CarOrderId { get; set; }
    public string NameOfCar { get; set; }
    public string ModelOfCar { get; set; }
    public string ShortModelOfCar { get; set; }
    public int YearOfCar { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }
    
    public string User { get; set; }
}