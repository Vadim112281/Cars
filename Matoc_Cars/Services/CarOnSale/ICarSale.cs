using Matoc_Cars.Models.CarSale;
using Matoc_Cars.Models.SellCar;
using Matoc_Cars.Services.SellCars;

namespace Matoc_Cars.Services.CarOnSale;

public interface ICarSale
{
    Task<IEnumerable<SellCarModel>> GetAll();
    IEnumerable<SellCarModel> GetByCategory(SaledCar model);

    SellCarModel GetCarById(int id);
}