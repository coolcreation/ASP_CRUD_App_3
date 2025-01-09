using System.Collections.Generic;
using System.Linq;

namespace ASP_CRUD_App.Models
{
    public class CarCategoryViewModel
    {
        public List<Car> Cars { get; set; }
        public List<Category> Categories { get; set; }

        public Car Car { get; set; } // Single Car
        public Category Category { get; set; } // Associated Category

        // Constructor to initialize lists
        public CarCategoryViewModel()
        {
            Cars = new List<Car>();
            Categories = new List<Category>();
        }

        // Method to get sorted cars by a specified property
        public List<Car> GetSortedCars(string sortBy = "Make")
        {
            return sortBy.ToLower() switch
            {
                "make" => Cars.OrderBy(c => c.Make).ToList(),
                "model" => Cars.OrderBy(c => c.Model).ToList(),
                "year" => Cars.OrderBy(c => c.Year).ToList(),
                "price" => Cars.OrderBy(c => c.Price).ToList(),
                _ => Cars // Default to unsorted if an invalid sortBy is provided
            };
        }

    }
}
