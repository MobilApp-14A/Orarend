﻿using System;
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
            connection.CreateTableAsync<List<Nap>>().Wait();
        }

        public void NapokHozzaadasa(List<Nap> napok)
        {
            connection.InsertAsync(napok);
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