using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;

namespace Check_Roles.Pages.Dozent_Tabelle
{
    public class DetailsModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public DetailsModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
