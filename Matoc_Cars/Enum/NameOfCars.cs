using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Matoc_Cars.Enum;

public enum NameOfCars
{
    [Display(Name = "Мercedes-Benz")]
    Mercedes,
    BMW,
    KIA,
    Ford
}