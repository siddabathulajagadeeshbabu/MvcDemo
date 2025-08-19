using System.ComponentModel.DataAnnotations;

namespace MvcDemo.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]


        
        public string Name { get; set; }

         [Required(0.01,10000.0,ErrorMessage = " Price must be between 0.01 and 10000.0.")]
        
        
        public decimal Price  { get; set; }
    }
}