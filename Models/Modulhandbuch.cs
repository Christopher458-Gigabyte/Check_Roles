using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_Roles.Models
{
    public partial class Modulhandbuch
    {
        public int ModulhandbuchId { get; set; }
        public string Name { get; set; }
        public int? FachbereichId { get; set; }
        public int? StudiengangId { get; set; }
        public string Prüfungsordnung { get; set; }
    }
}
