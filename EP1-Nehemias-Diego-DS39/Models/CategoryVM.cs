using EP1_nehemias_diego_ds39.Models;
using System.ComponentModel.DataAnnotations;

namespace EP1_Nehemias_Diego_DS39.Models
{
    public class CategoryVM
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
    }
}
