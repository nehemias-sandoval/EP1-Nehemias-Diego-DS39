using System.ComponentModel.DataAnnotations;

namespace EP1_nehemias_diego_ds39.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Picture Url")]
        public string PictureUrl { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
