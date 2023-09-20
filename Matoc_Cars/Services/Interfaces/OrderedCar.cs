using Matoc_Cars.Areas.Identity.Data;

namespace Matoc_Cars.Services.Interfaces;

public class OrderedCar: IOrderedCar
{
    private readonly AppDbContext _context;

    public OrderedCar(AppDbContext context)
    {
        _context = context;
    }

    public bool OrderCar(Models.CarOrder carOrder)
    {
        _context.OrderedCars.Add(carOrder);
        _context.SaveChanges();
        
        return true;
    }
}