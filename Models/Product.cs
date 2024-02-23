using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Product
    {
        public string Name { get; set; } = "";

        public string Brand { get; set; } = "";

        public string Category { get; set; } = "";

        public decimal Price { get; set; }

        public string Description { get; set; } = "";
    }
}
