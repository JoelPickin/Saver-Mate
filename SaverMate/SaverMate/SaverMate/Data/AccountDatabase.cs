using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SaverMate.Models;

namespace SaverMate.Data
{
    public class AccountDatabase
    {
        readonly SQLiteAsyncConnection database;

        public AccountDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Models.Account>().Wait();
        }

        public Task<List<Models.Account>> GetAccountsAsync()
        {
            return database.Table<Models.Account>().ToListAsync();
        }

        public Task<Models.Account> GetAccountAsync(int id)
        {
            return database.Table<Models.Account>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<List<Models.Account>> GetDeletedAsync()
        {
            return database.QueryAsync<Models.Account>("SELECT * FROM [Account] WHERE [Deleted] = 1");
        }

        public Task<int> SaveAccountAsync(Models.Account account)
        {           
            if (account.Id != 0)
            {
                return database.UpdateAsync(account);
            }
            else
            {
                return database.InsertAsync(account);
            }
        }

        public Task<int> DeleteAccountAsync(Models.Account account)
        {
            return database.DeleteAsync(account);
        }
    }
}
