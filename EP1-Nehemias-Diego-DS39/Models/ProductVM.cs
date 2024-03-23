using EP1_nehemias_diego_ds39.Models;
using System.ComponentModel.DataAnnotations;

namespace EP1_Nehemias_Diego_DS39.Models
{
    public class ProductVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        public int QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

    }
}
