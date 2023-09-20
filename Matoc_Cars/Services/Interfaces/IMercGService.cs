using Matoc_Cars.Models.Mercedes;

namespace Matoc_Cars.Services.Interfaces;

public interface IMercGService
{
    bool Add(G_Class car);

   IEnumerable<G_Class> GetByYear(int year);

   bool Delete(G_Class car);

   G_Class GetById(int id);
}