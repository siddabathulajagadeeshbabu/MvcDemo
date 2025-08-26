//adding Data annotations for validation purpose
using System.ComponentModel.DataAnnotations;
namespace MvcDemo.Models
{
    public class Product
    {

        public int id { get; set; }
        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }
    }
}