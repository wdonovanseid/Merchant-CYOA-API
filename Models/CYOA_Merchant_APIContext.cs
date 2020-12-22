using Microsoft.EntityFrameworkCore;

namespace CYOA_Merchant_API.Models
{
  public class CYOA_Merchant_APIContext : DbContext
  {
    public CYOA_Merchant_APIContext(DbContextOptions<CYOA_Merchant_APIContext> options)
        : base(options)
    {
    }

    public DbSet<Location> Locations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Location>()
          .HasData(
              new Location
              {
                LocationId = 1,
                LocationTitle = "Cave",
                LocationDescription ="Likes knocking things over"
              }
          );
    }
  }
}