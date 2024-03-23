using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EP1_Nehemias_Diego_DS39.Data;
using EP1_nehemias_diego_ds39.Models;
using EP1_Nehemias_Diego_DS39.Models;

namespace EP1_Nehemias_Diego_DS39.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext _context;

        public CreateModel(EP1_Nehemias_Diego_DS39.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryVM CategoryVM { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var entry = _context.Add(new Category());
            entry.CurrentValues.SetValues(CategoryVM);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
