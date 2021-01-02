using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Check_Roles.Models;

namespace Check_Roles.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Check_Roles.Models.Module> Module { get; set; }
        public DbSet<Check_Roles.Models.Änderung> Änderung { get; set; }
        public DbSet<Check_Roles.Models.Dozenten> Dozenten { get; set; }
        public DbSet<Check_Roles.Models.Fachbereich> Fachbereich { get; set; }
        public DbSet<Check_Roles.Models.Modulhandbuch> Modulhandbuch { get; set; }
        public DbSet<Check_Roles.Models.Studiengang> Studiengang { get; set; }
    }
}
