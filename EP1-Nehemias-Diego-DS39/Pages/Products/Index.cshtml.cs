using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EP1_Nehemias_Diego_DS39.Data;
using EP1_nehemias_diego_ds39.Models;

namespace EP1_Nehemias_Diego_DS39.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext _context;

        public IndexModel(EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get;set; } = default!;

        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;

            IQueryable<Product> productsIQ = from p in _context.Products.Include(p => p.Category).Include(p => p.Supplier) select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                productsIQ = productsIQ.Where(p => p.ProductName.Contains(searchString));
            }

            Products = await productsIQ.AsNoTracking().ToListAsync();
        }
    }
}
