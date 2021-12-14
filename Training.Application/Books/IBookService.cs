using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Application.Books
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
        Book Get(int id);
        void Update(Book book);
        void Create(Book book);
        void Delete(int id);
    }
}