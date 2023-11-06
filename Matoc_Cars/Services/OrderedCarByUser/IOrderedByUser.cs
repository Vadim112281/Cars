using Matoc_Cars.Models;

namespace Matoc_Cars.Services.OrderedCarByUser;

public interface IOrderedByUser
{
    List<CarOrder> OrderedCarByUser(string user);
}