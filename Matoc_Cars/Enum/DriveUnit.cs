using System.ComponentModel.DataAnnotations;

namespace Matoc_Cars.Enum;

public enum DriveUnit
{
    [Display(Name = "Повний привід")]
    full,
    [Display(Name = "Передній привід")]
    front,
    [Display(Name = "Задній привід")]
    back
}