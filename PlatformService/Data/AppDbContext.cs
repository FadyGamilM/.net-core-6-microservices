using PlatformService.Models;
using Microsoft.EntityFrameworkCore;
namespace PlatformService.Data
{
   public class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
      {
         // thats it .. 
      }      
      //! define our model as domain class 
      public DbSet<Platform> Platforms {get; set;}
   }
}