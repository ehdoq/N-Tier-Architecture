using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        protected IConfiguration? Configuration { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Model>? Models { get; set; }

        public AppDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(a =>
            {
                a.ToTable("Brands").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
                a.HasMany(p => p.Models);
            });

            modelBuilder.Entity<Model>(a =>
            {
                a.ToTable("Models").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.BrandId).HasColumnName("BrandId");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.DailyPrice).HasColumnName("DailyPrice").HasColumnType("decimal(18,2)");
                a.Property(p => p.ImageUrl).HasColumnName("ImageUrl");
                a.HasOne(p => p.Brand);
            });

            Brand[] brandEntitySeeds = 
            { 
                new(1, "BMW"), 
                new(2, "Mercedes") 
            };
            modelBuilder.Entity<Brand>().HasData(brandEntitySeeds);

            Model[] modelEntitySeeds = 
            {
                new(1, 1, "Series 4", 1500m, ""), 
                new(2, 1, "Series 3", 1200m, ""), 
                new(3, 2, "A180", 1000m, "") ,
                new(4, 2, "A3", 500m, "") 
            };
            modelBuilder.Entity<Model>().HasData(modelEntitySeeds);
        }
    }
}