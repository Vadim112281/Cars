using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models;

namespace Matoc_Cars.Services.ProcesOfOrder;

public class FindHaveCar: IFindHaveCar
{
    private readonly AppDbContext _context;

    public FindHaveCar(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<HaveCarForOrder> FindCarByName(string modelOfCar, int yearOfCar)
    {
        var FindCar = _context.CarsForOrder.Where(x => x.ShortName == modelOfCar && x.YearOfCar == yearOfCar).ToList();

        return FindCar;
    }

    public HaveCarForOrder GetById(int id)
    {
        var car = _context.CarsForOrder.FirstOrDefault(x => x.Id == id);

        return car;
    }
}