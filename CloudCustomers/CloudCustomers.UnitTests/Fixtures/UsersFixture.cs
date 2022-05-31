using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new()
            {
                Id = 1,
                Name = "Test user 1",
                Address = new Address()
                {
                    Street = "Cementerio",
                    City = "Diriamba",
                    ZipCode = "43600"
                },
                Email = "emial@email.com"
            },
            new()
            {
                Id = 2,
                Name = "Test user2",
                Address = new Address()
                {
                    Street = "Cementerio",
                    City = "Diriamba",
                    ZipCode = "43600"
                },
                Email = "user2@email.com"
            }
        };
    }
}
