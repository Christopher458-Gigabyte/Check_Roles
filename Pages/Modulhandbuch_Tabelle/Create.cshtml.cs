using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Modulhandbuch_Tabelle
{
    public class CreateModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public CreateModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Modulhandbuch Modulhandbuch { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Modulhandbuch.Add(Modulhandbuch);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
