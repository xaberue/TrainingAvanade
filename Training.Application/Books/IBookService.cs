using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Application.Books
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
        void Update(Book book);
    }
}