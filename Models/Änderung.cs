using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Check_Roles.Models
{
    public partial class Änderung
    {
        public int ÄnderungId { get; set; }
        public int? AdminId { get; set; }
        public int? DozentId { get; set; }
        public int? ModulId { get; set; }
        public string AlterEintrag { get; set; }
        public string NeuerEintrag { get; set; }
        public DateTime? Datum { get; set; }
        public int? ModulhandbuchId { get; set; }
        public string Fachbereich { get; set; }
        public string Status { get; set; }
    }
}
