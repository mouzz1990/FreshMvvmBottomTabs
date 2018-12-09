using Fresh1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fresh1.Services
{
    public interface IDataService
    {
        Task<List<Contact>> GetContacts();
    }
}
