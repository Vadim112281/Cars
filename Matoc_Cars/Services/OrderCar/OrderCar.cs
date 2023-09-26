using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models;

namespace Matoc_Cars.Services.OrderCar;

public class OrderCar: IOrderCar
{
    private readonly AppDbContext _context;

    public OrderCar(AppDbContext context)
    {
        _context = context;
    }

    public bool OrderedCar(CarOrder car)
    {
        _context.OrderedCars.Add(car);
        _context.SaveChanges();
        return true;
    }
}