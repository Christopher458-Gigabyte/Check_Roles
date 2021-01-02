using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_Roles.Models
{
    public partial class Fachbereich
    {
        public int FachbereichId { get; set; }
        public string Name { get; set; }
        public int? AdminId { get; set; }
        public string Studiengänge { get; set; }
    }
}
