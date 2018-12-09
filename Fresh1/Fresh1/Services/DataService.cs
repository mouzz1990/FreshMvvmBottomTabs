using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Fresh1.Models;

namespace Fresh1.Services
{
    public class DataService : IDataService
    {
        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            return new List<Contact>()
            {
                new Contact() { Name = "Dima", LastName = "Kalf" },
                new Contact() { Name = "Sergey", LastName = "Kalf" },
                new Contact() { Name = "Alex", LastName = "Kalf" },
                new Contact() { Name = "Veronika", LastName = "Kalf" },
            };
        }
    }
}
