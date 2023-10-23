using System.ComponentModel.DataAnnotations;

namespace Matoc_Cars.Enum;

public enum Engine
{
    [Display(Name = "2 л | Бензин")]
    two_benzin,
    [Display(Name = "2 л | Дизель")]
    two_disel
    
}