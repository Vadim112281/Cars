using Matoc_Cars.Areas.Identity.Data;
using Matoc_Cars.Models;
using Matoc_Cars.Models.Mercedes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Matoc_Cars.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<G_Class> G_Class { get; set; }
    public DbSet<CarOrder> OrderedCars { get; set; }
    public DbSet<HaveCarForOrder> CarsForOrder { get; set; }
}
