using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
        {
            new User { Id = Guid.NewGuid(), Name = "User1", Password = "Test1234", NationalIdentifier = "12345678A"},
            new User { Id = Guid.NewGuid(), Name = "User2", Password = "Test1234", NationalIdentifier = "12345678B"}
        };
        public User Get(string username, string password)
        {
            return _users.FirstOrDefault(x => x.Name == username && x.Password == password);
        }
    }
}
