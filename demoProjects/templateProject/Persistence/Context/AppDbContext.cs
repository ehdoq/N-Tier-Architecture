using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context
{
    public class AppDbContext : DbContext
    {
        protected IConfiguration? Configuration { get; set; }
        public DbSet<SomeFeatureEntity>? SomeFeatureEntities { get; set; }

        public AppDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SomeFeatureEntity>(a =>
            {
                a.ToTable("SomeFeatureEntities").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.Name).HasColumnName("Name");
            });

            SomeFeatureEntity[] someFeatureEntitySeeds = { new(1, "Test 1"), new(2, "Test 2") };
            modelBuilder.Entity<SomeFeatureEntity>().HasData(someFeatureEntitySeeds);
        }
    }
}