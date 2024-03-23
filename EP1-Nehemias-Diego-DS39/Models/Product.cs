using System.ComponentModel.DataAnnotations;

namespace EP1_nehemias_diego_ds39.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        [Required]
        [Display(Name = "Quantity Per Unit")]
        public int QuantityPerUnit { get; set; }

        [Required]
        [Display(Name = "Unit Price")]
        public double UnitPrice { get; set; }

        [Required]
        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }

        [Required]
        [Display(Name = "Units On Order")]
        public int UnitsOnOrder { get; set; }

        [Required]
        [Display(Name = "Reorder Level")]
        public int ReorderLevel { get; set; }

        [Required]
        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
    }
}
