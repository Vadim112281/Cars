using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models.SellCar;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace Matoc_Cars.Services.SellCars;

public class SellCar: ISellCar
{
    private readonly AppDbContext _context;

    public SellCar(AppDbContext context)
    {
        _context = context;
    }

    public bool Add(SellCarModel model)
    {
        _context.SellCars.Add(model);
        _context.SaveChanges();
        
        return true;
    }
}