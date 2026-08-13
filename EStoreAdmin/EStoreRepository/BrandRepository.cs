using EstoreModel.Models.BrandModels;
using Microsoft.EntityFrameworkCore;

namespace EStoreRepository
{
    public class BrandRepository:DbContext
    {

      public BrandRepository(DbContextOptions<BrandRepository>options)
            : base(options) 
        { }
        
        public DbSet<BrandModel>Brands { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            //create a Table Name with coulmn in database
            modelBuilder.Entity<BrandModel>().ToTable("Brands");

            //Create a primary key in the table Brands
            modelBuilder.Entity<BrandModel>().HasKey("Id");

            modelBuilder.Entity<BrandModel>().HasData(
               new BrandModel
               {
                   Id = Guid.NewGuid(),
                   Name = "Brand 1"
               },
               new BrandModel
               {
                   Id = Guid.NewGuid(),
                   Name = "Brand 2"
               },
               new BrandModel
               {
                   Id = Guid.NewGuid(),
                   Name = "Brand 3"
               }
                );
            */
        }
    }
}
