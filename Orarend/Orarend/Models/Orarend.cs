using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orarend.Models
{
    internal class Orarend
    {
        public int orakHossza { get; set; } //percben
        public int szunetekHossza { get; set; }
        public int nagySzunetHossza { get; set; }
        public int hanyadikOraUtanVanNagySzunet { get; set; }
        public List<Ora> orak { get; set; } //név, tanár, terem
    }
}
