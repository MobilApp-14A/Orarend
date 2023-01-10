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
    public class Database2
    {
        readonly SQLiteAsyncConnection connection;

        public Database2(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<Nap>().Wait();
        }

        public void NapokHozzaadasa(Nap nap)
        {
            connection.InsertAsync(nap);
        }

        public bool NapTorlese(Nap kivalasztott)
        {
            return connection.DeleteAsync(kivalasztott).Result == 1;
        }

        public ObservableCollection<Nap> NapokKilistazasa()
        {
            return new ObservableCollection<Nap>(connection.Table<Nap>().ToListAsync().Result);
        }

    }
}