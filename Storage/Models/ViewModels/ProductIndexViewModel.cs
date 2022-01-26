using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models.ViewModels
{
    public class ProductIndexViewModel
    {
        public int Id { get; set; }  
        
        [Display(Name = "Produktnamn")]
        public string Name { get; set; }
        [Display(Name = "Pris")]
        public int Price { get; set; }
        [Display(Name = "Antal")]
        public int Count { get; set; }
        [Display(Name = "Värde i kronor")]
        public int InventoryValue { get; set; }
    }
}
