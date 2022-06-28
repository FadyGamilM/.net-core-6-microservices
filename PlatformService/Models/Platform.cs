using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
   public class Platform
   {
      [Key]
      [Required]
      public int id {get; set;}
      [Required]
      public string Name { get; set; }
      [Required]
      public string Publisher { get; set; }
   }
}