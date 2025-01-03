using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_CRUD_App.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Rating { get; set; }

        public string CarImage { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
