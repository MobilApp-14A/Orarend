using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orarend.Models
{
    public class Ora
    {

        public string nev { get; set; }
        public string tanar { get; set; }
        public string terem { get; set; }
        public int oraTol { get; set; }
        public int percTol { get; set; }
        public int oraIg { get; set; }
        public int percIg { get; set; }
    }
}
