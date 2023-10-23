using Matoc_Cars.Models.SellCar;

namespace Matoc_Cars.Services.SellCars;

public interface ISellCar
{
    bool Add(SellCarModel model);
}