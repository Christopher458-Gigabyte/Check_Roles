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

namespace Check_Roles.Pages.Dozent_Tabelle
{
    public class EditModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public EditModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dozenten Dozenten { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dozenten = await _context.Dozenten.FirstOrDefaultAsync(m => m.DozentId == id);

            if (Dozenten == null)
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

            _context.Attach(Dozenten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DozentenExists(Dozenten.DozentId))
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

        private bool DozentenExists(int id)
        {
            return _context.Dozenten.Any(e => e.DozentId == id);
        }
    }
}
