using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Training.Application.Books;

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

    }
}
