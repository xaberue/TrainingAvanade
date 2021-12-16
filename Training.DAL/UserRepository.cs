using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class UserRepository : IUserRepository
    {

        private readonly TrainingDbContext _trainingDbContext;

        public UserRepository(TrainingDbContext context)
        {
            _trainingDbContext = context;
        }

        public User Get(string username, string password)
        {
            return _trainingDbContext.Users
                .FirstOrDefault(x => x.Name == username && x.Password == password);
        }
    }
}
