using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models;

namespace Matoc_Cars.Services.OrderedCarByUser;

public class OrderedByUser: IOrderedByUser
{
    private readonly AppDbContext _context;

    public OrderedByUser(AppDbContext context)
    {
        _context = context;
    }

    public List<CarOrder> OrderedCarByUser(string user)
    {
        var cars = _context.OrderedCars.Where(x => x.User == user).ToList();

        return cars;
    }
}