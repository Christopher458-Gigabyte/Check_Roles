using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Änderung
{
    public class EditModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public EditModel(Check_Roles.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Änderung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ÄnderungExists(Änderung.ÄnderungId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ÄnderungExists(int id)
        {
            return _context.Änderung.Any(e => e.ÄnderungId == id);
        }
    }
}
