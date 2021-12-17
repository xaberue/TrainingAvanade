using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(string username, string password);
        User Get(string userIdentifier);
    }
}
