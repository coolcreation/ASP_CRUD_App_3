
using System.Linq;
using ASP_CRUD_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_CRUD_App.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext context { get; set; }

        public HomeController(AppDbContext ctx) => context = ctx;


        public IActionResult Index(string sortBy)
        {
            var cars = context.Cars
                .Include(c => c.Category).ToList();

            var viewModel = new CarCategoryViewModel
            {
                Cars = cars
            };

            sortBy = string.IsNullOrEmpty(sortBy) ? "Make" : sortBy; // Default sort by "Make"
            var sortedCars = viewModel.GetSortedCars(sortBy);

            // Replace the Cars list in the ViewModel with the sorted list
            viewModel.Cars = sortedCars;

            ViewBag.SortName = sortBy.ToUpper();
            return View(viewModel); 
        }


        public IActionResult ConfirmRental(int id)
        {
            var vehicle = context.Cars
                .Include(c => c.Category)
                .FirstOrDefault(c => c.CarId == id);

            if (vehicle == null)
            {
                return NotFound(); // Handle case where vehicle is not found
            }

            var viewModel = new CarCategoryViewModel
            {
                Car = vehicle,
                Category = vehicle.Category // Assuming Car includes a navigation property for Category
            };

            return View(viewModel);
        }


        public IActionResult EditVehicle(int id)
        {
            var vehicle = context.Cars
                .FirstOrDefault(c => c.CarId == id);

            if (vehicle == null)
            { 
                return NotFound(); // Handle case where vehicle is not found
            }

            var viewModel = new CarCategoryViewModel
            {
                Car = vehicle,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditVehicle(Car car)
        {
            var vehicle = context.Cars
                .FirstOrDefault(c => c.CarId == car.CarId);

            if (vehicle == null)
            {
                return NotFound(); // Handle case where vehicle is not found
            }

            // Update the properties of the vehicle
            vehicle.Make = car.Make;
            vehicle.Model = car.Model;
            vehicle.Year = car.Year;
            vehicle.Color = car.Color;
            vehicle.Price = car.Price;
            // Add other properties as necessary

            // Save changes to the database
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
