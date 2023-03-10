// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Name = "Italy",
                            Price = 3575,
                            TemperatureC = 25
                        },
                        new
                        {
                            DestinationId = 2,
                            Name = "Croatia",
                            Price = 4689,
                            TemperatureC = 28
                        },
                        new
                        {
                            DestinationId = 3,
                            Name = "Greece",
                            Price = 7999,
                            TemperatureC = 22
                        },
                        new
                        {
                            DestinationId = 4,
                            Name = "South Africa",
                            Price = 3058,
                            TemperatureC = 17
                        },
                        new
                        {
                            DestinationId = 5,
                            Name = "Serbia",
                            Price = 4089,
                            TemperatureC = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
