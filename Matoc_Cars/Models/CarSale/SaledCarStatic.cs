using Matoc_Cars.Enum;
using Matoc_Cars.Enum.Years;

namespace Matoc_Cars.Models.CarSale;

public static class SaledCarStatic
{
    public static string NameOfCar;
    public static string ModelOfCar { get; set; }
    public static YearsOfCars YearOfCar { get; set; }
    public static int PriceFrom { get; set; }
    public static int PriceUnder { get; set; }
}