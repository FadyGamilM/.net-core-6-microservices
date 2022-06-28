using PlatformService.Models;
namespace PlatformService.Data
{
   public interface IPlatformRepo
   {
      //! Save changes method which apply the tracked changes from
      //! DbContext instance to the DB instance we are dealing with
      bool SaveChanges();

      //! retrieve all Platforms
      IEnumerable<Platform> GetPlatforms();

      //! retrieve platform by id
      Platform GetPlatformById(int id);

      //! create a platform
      void CreatePlatform(Platform platform);
   }
}