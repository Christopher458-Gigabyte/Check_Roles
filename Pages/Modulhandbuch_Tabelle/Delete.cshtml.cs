using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Modulhandbuch_Tabelle
{
    public class DeleteModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public DeleteModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modulhandbuch Modulhandbuch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Modulhandbuch = await _context.Modulhandbuch.FirstOrDefaultAsync(m => m.ModulhandbuchId == id);

            if (Modulhandbuch == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Modulhandbuch = await _context.Modulhandbuch.FindAsync(id);

            if (Modulhandbuch != null)
            {
                _context.Modulhandbuch.Remove(Modulhandbuch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
