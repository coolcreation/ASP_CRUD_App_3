
using System.Collections.Generic;
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

        public IActionResult Index()
        {
            var cars = context.Cars
                .Include(c => c.Category)
                .OrderBy(m => m.Make).ToList();

            var viewModel = new CarCategoryViewModel
            {
                Cars = cars
            };

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


    }
}
