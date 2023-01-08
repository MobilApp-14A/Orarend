using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orarend.Models
{
    internal class Orarendek
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public List<Ora> orak { get; set; } //név, tanár, terem
    }
}
