using Matoc_Cars.Models;

namespace Matoc_Cars.Services.OrderCar;

public interface IOrderCar
{
    bool OrderedCar(CarOrder car);
}