using DataCapturing.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataCapturing.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Recipient>();
            _database.CreateTableAsync<User>();
            _database.CreateTableAsync<Organisaztion>();
            _database.CreateTableAsync<Donation>();
            
        }

        public Task<List<Recipient>> GetRecipientsAsync()
        {
            return _database.Table<Recipient>().ToListAsync();
        }

        public async Task<List<Recipient>> GetRecipientsAsync(string name )
        {
            var recipients = await _database.Table<Recipient>().ToListAsync();
            return recipients.FindAll(x => x.FirstName == name);
        }

        public Task<int> SaveRecipientAsync(Recipient recipients)
        {
            return _database.InsertAsync(recipients);
        }

        public Task<int> UpdateRecipient(Recipient recipient)
        {
            return _database.UpdateAsync(recipient);
        }

        public Task<int> DeleteRecipient(Recipient recipient)
        {
            return _database.DeleteAsync(recipient);
        }

        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        public Task<int> UpdateUser(User user)
        {
            return _database.UpdateAsync(user);
        }

        public Task<int> DeleteUser(User user)
        {
            return _database.DeleteAsync(user);
        }

        public Task<List<Organisaztion>> GetOrganizationsAsync()
        {
            return _database.Table<Organisaztion>().ToListAsync();
        }

  

        public Task<int> SaveOrganizationAsync(Organisaztion organization)
        {
            return _database.InsertAsync(organization);
        }

        public Task<int> UpdateOrganization(Organisaztion organization)
        {
            return _database.UpdateAsync(organization);
        }

        public Task<int> DeleteOrganization(Organisaztion organization)
        {
            return _database.DeleteAsync(organization);
        }

        public Task<List<Donation>> GetDonationsAsync()
        {
            return _database.Table<Donation>().ToListAsync();
        }



        public Task<int> SaveDonationAsync(Donation donation)
        {
            return _database.InsertAsync(donation);
        }

        public Task<int> UpdateDonation(Donation donation)
        {
            return _database.UpdateAsync(donation);
        }

        public Task<int> DeleteDonation(Donation donation)
        {
            return _database.DeleteAsync(donation);
        }

    }


}
