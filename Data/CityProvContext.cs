using CityProv.Models;
using Microsoft.EntityFrameworkCore;

public class CityProvContext : DbContext {
    public CityProvContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
        //base.OnModelCreating(builder);
    }

    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Cities { get; set; }
}
