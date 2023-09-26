using System.Collections.Generic;
using Matoc_Cars.Models;

namespace Matoc_Cars.Services.ProcesOfOrder;

public interface IFindHaveCar
{
    IEnumerable<HaveCarForOrder> FindCarByName(string modelOfCar, int yearOfCar);
    HaveCarForOrder GetById(int id);
}