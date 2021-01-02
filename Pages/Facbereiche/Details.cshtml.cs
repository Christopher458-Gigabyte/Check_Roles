using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Facbereiche
{
    public class DetailsModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public DetailsModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Fachbereich Fachbereich { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fachbereich = await _context.Fachbereich.FirstOrDefaultAsync(m => m.FachbereichId == id);

            if (Fachbereich == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
