using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_Roles.Models
{
    public partial class Studiengang
    {
        public int StudiengangId { get; set; }
        public string Name { get; set; }
        public int? FachbereichId { get; set; }
        public string Modulhandbücher { get; set; }
    }
}
