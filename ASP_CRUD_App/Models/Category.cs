using System.Collections.Generic;

namespace ASP_CRUD_App.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageName{ get; set; }

        public List<Car> Cars { get; set; }
    }
}
