using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public int TemperatureC { get; set; }
    [Required]
    public int Price { get; set; }

    public string? Summary { get; set; }
  }
}


// dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 6.0.0
// dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 6.0.0

// dotnet tool install -g dotnet-aspnet-codegenerator --version 6

// dotnet aspnet-codegenerator controller -name DestinationsController -async -api -m Destination -dc TravelApiContext -outDir Controllers