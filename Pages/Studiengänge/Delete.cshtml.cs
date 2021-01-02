using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Studiengänge
{
    public class DeleteModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public DeleteModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Studiengang Studiengang { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Studiengang = await _context.Studiengang.FirstOrDefaultAsync(m => m.StudiengangId == id);

            if (Studiengang == null)
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

            Studiengang = await _context.Studiengang.FindAsync(id);

            if (Studiengang != null)
            {
                _context.Studiengang.Remove(Studiengang);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
