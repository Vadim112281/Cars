using Matoc_Cars.Enum;

namespace Matoc_Cars.Models.SellCar;

public class SellCarModel
{
    public int Id { get; set; }
    public NameOfCars NameOfCar { get; set; }
    public string ModelOfCar { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Transmission Transmission { get; set; }
    public Color Color { get; set; }
    public DriveUnit DriveUnit { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public int Mileage { get; set; }
}