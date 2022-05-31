using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudCustomers.API.Services
{
    public interface IUsersService
    {
        public Task<List<User>> GetAllUsers();
    }

    public class UsersService : IUsersService
    {
        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
