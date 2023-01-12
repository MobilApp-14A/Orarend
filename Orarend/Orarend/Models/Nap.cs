using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orarend.Models
{
    public class Nap
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [TextBlob("orakBlobbed")]
        public List<Ora> orak { get; set; }
        public string orakBlobbed { get; set; }

    }
}
