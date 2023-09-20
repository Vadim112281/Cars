using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Matoc_Cars.Services.Interfaces;

namespace Matoc_Cars.Services;

public class MercGService: IMercGService
{
    private readonly AppDbContext _context;

    public MercGService(AppDbContext context)
    {
        _context = context;
    }

    public bool Add(G_Class car)
    {
        _context.G_Class.Add(car);
        _context.SaveChanges();
        return true;
    }



    public IEnumerable<G_Class> GetByYear(int year)
    {
        return _context.G_Class.Where(x => x.YearOfCar == year).ToList();
    }

    public bool Delete(G_Class car)
    {
        _context.G_Class.Remove(car);
        _context.SaveChanges();

        return true;
    }

    public G_Class GetById(int id)
    {
        var car = _context.G_Class.FirstOrDefault(x => x.Id == id);

        return car;
    }
}