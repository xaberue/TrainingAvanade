using Microsoft.AspNetCore.Mvc;
using Training.Application.Books;
using Training.Core.Models;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;


        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        [HttpGet]
        public IActionResult Get() 
        {
            var books = _bookService.Get();

            return Ok(books);
        }

        [HttpPut]
        public IActionResult Put(Book book) 
        {
            _bookService.Update(book);

            return Ok();
        }

    }
}
