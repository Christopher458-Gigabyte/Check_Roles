using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Data;
using Check_Roles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Check_Roles.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


namespace Check_Roles.Pages.Modules
{

    //public class IndexModel : PageModel
    //{
    //    private readonly Check_Roles.Data.ApplicationDbContext _context;

    //    public IndexModel(Check_Roles.Data.ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public IList<Module> Module { get; set; }

    //    public async Task OnGetAsync()
    //    {
    //        Module = await _context.Module.ToListAsync();
    //    }
    //}














    public class IndexModel : DI_BasePageModel
    {
        public IndexModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager)
            : base(context, authorizationService, userManager)
        {
        }

        public IList<Module> Module { get; set; }

        public async Task OnGetAsync()
        {
            var contacts = from c in Context.Module
                           select c;

            var isAuthorized = User.IsInRole(Constants.DekanRole) ||
                            User.IsInRole(Constants.AdminRole);

            var currentUserId = UserManager.GetUserId(User);

            // Only approved contacts are shown UNLESS you're authorized to see them
            // or you are the owner.
            if (!isAuthorized)
            {
                contacts = contacts.Where(c => c.Status == ContactStatus.Approved
                                            || c.OwnerID == currentUserId);
            }

            Module = await contacts.ToListAsync();
        }
    }
}



