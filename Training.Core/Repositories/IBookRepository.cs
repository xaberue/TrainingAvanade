using System;
using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Core.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> Get();
        Book Get(string isbn);
        void Create(Book book);
        void Update(Book book);
    }
}
