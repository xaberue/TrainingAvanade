using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;
using Training.DAL.Base;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class UserRepository : RepositoryBase, IUserRepository
    {

        public UserRepository(TrainingDbContext trainingDbContext)
           : base(trainingDbContext)
        { }

        public User Get(string username, string password)
        {            
            return _trainingDbContext.Users                
                .FirstOrDefault(x => x.Name == username && x.Password == password);
        }

        public User Get(string userIdentifier)
        {
            return _trainingDbContext.Users
                .FirstOrDefault(x => x.NationalIdentifier == userIdentifier);
        }

    }
}
