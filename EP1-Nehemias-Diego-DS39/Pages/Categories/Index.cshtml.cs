using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EP1_Nehemias_Diego_DS39.Data;
using EP1_nehemias_diego_ds39.Models;

namespace EP1_Nehemias_Diego_DS39.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext _context;

        public IndexModel(EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string CurrentFilter { get; set; }

        public IList<Category> Categories { get;set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;

            IQueryable<Category> categoriesIQ = from c in _context.Categories select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                categoriesIQ = categoriesIQ.Where(c => c.CategoryName.Contains(searchString));
            }

            Categories = await categoriesIQ.AsNoTracking().ToListAsync();
        }
    }
}
