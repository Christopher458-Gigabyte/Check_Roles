using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Check_Roles.Models
{
    public partial class Dozenten
    {
        [Key]
        public int DozentId { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string EMail { get; set; }
    }
}
