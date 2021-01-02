using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Änderung
{
    public class DeleteModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public DeleteModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Check_Roles.Models.Änderung Änderung { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Änderung = await _context.Änderung.FirstOrDefaultAsync(m => m.ÄnderungId == id);

            if (Änderung == null)
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

            Änderung = await _context.Änderung.FindAsync(id);

            if (Änderung != null)
            {
                _context.Änderung.Remove(Änderung);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
