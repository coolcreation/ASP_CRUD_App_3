using System.Collections.Generic;

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
    }
}
