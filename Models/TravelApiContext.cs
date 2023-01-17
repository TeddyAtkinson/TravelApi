using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Destination> Destinations { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
        .HasData(
          new Destination { DestinationId = 1, Name = "Italy", TemperatureC = 25, Price = 3575 },
          new Destination { DestinationId = 2, Name = "Croatia", TemperatureC = 28, Price = 4689 },
          new Destination { DestinationId = 3, Name = "Greece", TemperatureC = 22, Price = 7999 },
          new Destination { DestinationId = 4, Name = "South Africa", TemperatureC = 17, Price = 3058 },
          new Destination { DestinationId = 5, Name = "Serbia", TemperatureC = 12, Price = 4089 }
        );
    }
  }
}
