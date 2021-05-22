using projectlufi.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projectlufi.Databases
{
    public class ListItemDatabase
    {
        readonly SQLiteAsyncConnection _database;
         
        public ListItemDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ListItem>().Wait();
        }

        public Task<List<ListItem>> GetListsAsync()
        {
            return _database.Table<ListItem>().ToListAsync();
        }

        public Task<int> SaveListsAsync(ListItem listItem)
        {
            if(listItem.Id != 0)
                return _database.UpdateAsync(listItem);
            else
            {
                return _database.InsertAsync(listItem);

            }
            
        }
    }
}
