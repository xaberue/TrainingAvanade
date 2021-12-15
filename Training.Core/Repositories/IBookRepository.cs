using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> Get();
        Book Get(string isbn);
        void Update(Book book);
        void Create(Book book);
    }
}
