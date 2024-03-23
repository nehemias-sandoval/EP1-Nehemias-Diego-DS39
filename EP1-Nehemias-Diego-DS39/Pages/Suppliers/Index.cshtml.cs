using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EP1_Nehemias_Diego_DS39.Data;
using EP1_nehemias_diego_ds39.Models;

namespace EP1_Nehemias_Diego_DS39.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext _context;

        public IndexModel(EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string CurrentFilter { get; set; }

        public IList<Supplier> Suppliers { get;set; } = default!;

        public async Task OnGetAsync(string searchString)
        {
            CurrentFilter = searchString;

            IQueryable<Supplier> suppliersIQ = from s in _context.Suppliers select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                suppliersIQ = suppliersIQ.Where(s => s.CompanyName.Contains(searchString));
            }

            Suppliers = await suppliersIQ.AsNoTracking().ToListAsync();
        }
    }
}
