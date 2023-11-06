using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models.CarSale;
using Matoc_Cars.Models.SellCar;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Matoc_Cars.Services.CarOnSale;

public class CarSale: ICarSale
{
    private readonly AppDbContext _context;

    public CarSale(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SellCarModel>> GetAll()
    {
        var cars = await _context.SellCars.ToListAsync();

        return cars;
    }

    public IEnumerable<SellCarModel> GetByCategory(SaledCar model)
    {
        var CarForSale = _context.SellCars.Where(x => x.ModelOfCar == model.ModelOfCar && x.Price <= model.PriceUnder
            && x.Price >= model.PriceFrom).ToList();

        return CarForSale;
    }

    public  SellCarModel GetCarById(int id)
    {
        var car =  _context.SellCars.FirstOrDefault(x => x.Id == id);
        
        return car;

    }
}