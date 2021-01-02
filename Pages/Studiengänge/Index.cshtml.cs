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
    public class IndexModel : PageModel
    {
        private readonly Check_Roles.Data.ApplicationDbContext _context;

        public IndexModel(Check_Roles.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Studiengang> Studiengang { get;set; }

        public async Task OnGetAsync()
        {
            Studiengang = await _context.Studiengang.ToListAsync();
        }
    }
}
