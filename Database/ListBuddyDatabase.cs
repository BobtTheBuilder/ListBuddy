using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListBuddy.Models;
using SQLite;

namespace ListBuddy.Database
{
     class ListBuddyDatabase
    {
        SQLiteAsyncConnection database;

        public ListBuddyDatabase(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<UserInfo>().Wait();
        }

        public Task<UserInfo> GetUserInfoAsync(string username) 
        {
            return database.Table<UserInfo>().Where(i => i.Username == username).FirstOrDefaultAsync();
        }
    }
}
