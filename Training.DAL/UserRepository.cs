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
        private readonly TrainingDbContext _trainingDbContext;

        public UserRepository(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }
        public User Get(string username, string password)
        {
            return _trainingDbContext.Users.FirstOrDefault(x => x.Name == username && x.Password == password);
        }
        public User Get(string userIdentifier)
        {
            return _trainingDbContext.Users
                .FirstOrDefault(x => x.NationalIdentifier == userIdentifier);
        }
    }
}
