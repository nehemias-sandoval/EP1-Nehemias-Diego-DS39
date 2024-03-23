using System.ComponentModel.DataAnnotations;

namespace EP1_nehemias_diego_ds39.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Home Page")]
        public string HomePage { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
