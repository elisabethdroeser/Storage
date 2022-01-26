using System.ComponentModel.DataAnnotations;
namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Category { get; set; }
        [Range(1, 100)]
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

    }
}
