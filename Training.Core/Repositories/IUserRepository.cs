using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(string username, string password);
        User Get(string userIdentifier);
    }
}
