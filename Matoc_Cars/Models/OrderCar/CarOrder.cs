namespace Matoc_Cars.Models;

public class CarOrder
{
    public int Id { get; set; }
    public string NameOfCar { get; set; }
    public string ModelOfCar { get; set; }
    public int YearOfCar { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }
}