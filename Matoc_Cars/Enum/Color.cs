using System.ComponentModel.DataAnnotations;

namespace Matoc_Cars.Enum;

public enum Color
{
    [Display(Name = "Білий")]
    White,
    [Display(Name = "Чорний")]
    Black,
    [Display(Name = "Чорний матовий")]
    Black_Mat,    
}