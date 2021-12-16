using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Training.Application.Books;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
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

        [HttpGet("{isbn}")]
        public IActionResult Get(string isbn)
        {
            var book = _bookService.Get(isbn);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(BookDto book)
        {
            _bookService.Create(book);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(BookDto book) 
        {
            _bookService.Update(book);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string isbn) 
        {
            _bookService.Delete(isbn);

            return Ok();
        }

    }
}
