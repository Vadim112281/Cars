using Matoc_Cars.Enum;
using Matoc_Cars.Enum.Years;

namespace Matoc_Cars.Models.CarSale;

public class SaledCar
{
    public string NameOfCar { get; set; }
    public string ModelOfCar { get; set; }
    public YearsOfCars YearOfCar { get; set; }
    public int PriceFrom { get; set; }
    public int PriceUnder { get; set; }

}