using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.Collections.ObjectModel;
using Orarend.Models;

namespace Orarend.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection connection;

        public Database(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<Orarendek>().Wait();
        }

        internal void OrarendMentes(Orarendek orarend)
        {
            connection.InsertAsync(orarend);
        }

        internal bool OrarendTorles(Orarendek kivalasztott)
        {
            return connection.DeleteAsync(kivalasztott).Result == 1;
        }
    }
}