using Microsoft.EntityFrameworkCore;

namespace ASP_CRUD_App.Models
{
    public class AppDbContext : DbContext
    {
        // MovieContext is the constructor: base passes the options that come in up to the parent class
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        // Movies table where each record is a <Movie>, wrapped in Generics <> meaning any data type
        public DbSet<Car> Cars { get; set; } = null;
        public DbSet<Category> Categories { get; set; } = null; 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //   CarId, Make, Model, Year, Color, Price, Rating, CategoryId  
            modelBuilder.Entity<Car>().Property(p => p.Price).HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<Car>().HasData(
                new Car
                { CarId = 1, Make = "Ford", Model = "Galaxy", Year = 2008, Color = "Red", Price = 49.99M,  Rating = 3, CategoryId = "Van",
                CarImage = "ford_galaxy_2008.jpg"
                },
                new Car
                { CarId = 2, Make = "Honda", Model = "Civic", Year = 2006, Color = "Charcoal", Price = 39.99M, Rating = 5, CategoryId = "Sedan", 
                  CarImage= "honda_civic_2006.jpg"
                },
                new Car
                { CarId = 3, Make = "Toyota", Model = "Landcruiser", Year = 2005, Color = "Green", Price = 42.99M, Rating = 5, CategoryId = "SUV",
                CarImage= "toyota_landcruiser100_2005.jpg"
                },
                new Car
                { CarId = 4, Make = "VW", Model = "Golf", Year = 2008, Color = "Silver", Price = 65.99M, Rating = 2, CategoryId = "Hatchback",
                CarImage= "vw_golf_2008.jpg"
                },
                new Car
                { CarId = 5, Make = "Lincoln", Model = "Towncar", Year = 2006, Color = "White", Price = 105.99M, Rating = 4, CategoryId = "Limousine",
                CarImage= "lincoln_towncar_2006.jpg"
                }
            );

        modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "Sedan", CategoryName = "Sedan", ImageName = "Sedan.png" },
                new Category { CategoryId = "Hatchback", CategoryName = "Hatchback", ImageName = "Hatchback.png" },
                new Category { CategoryId = "SUV", CategoryName = "SUV", ImageName = "SUV.png" },
                new Category { CategoryId = "Limousine", CategoryName = "Limousine", ImageName = "Limousine.png" },
                new Category { CategoryId = "Van", CategoryName = "Van", ImageName = "Van.png" }
            );
        }
    }
}
 