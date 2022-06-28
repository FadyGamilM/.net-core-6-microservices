using PlatformService.Models;

namespace PlatformService.Data
{
   public class PlatformRepo : IPlatformRepo
   {
      //! utilize the injected DbContext service
      private readonly AppDbContext _context;
      public PlatformRepo(AppDbContext context)
      {
         this._context  = context;         
      }
      //!----------------------------------------

      public void CreatePlatform(Platform platform)
      {
         if (platform == null)
         {
            throw new ArgumentNullException(nameof(platform));
         }
         this._context.Platforms.Add(platform);
      }

      public Platform GetPlatformById(int id)
      {
         return this._context.Platforms.FirstOrDefault(p => p.id == id);
      }

      public IEnumerable<Platform> GetPlatforms()
      {
         return this._context.Platforms.ToList();
      }

      public bool SaveChanges()
      {
         return (this._context.SaveChanges() >= 0);
      }
   }
}