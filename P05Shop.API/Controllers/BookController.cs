using Microsoft.AspNetCore.Mvc;
using P04WeatherForecastAPI.Client.Models;
using P06Shop.Shared;
using P06Shop.Shared.Services.BookService;
using P06Shop.Shared.Shop;

namespace P05Shop.API.Controllers
{
    [Route("/")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<ActionResult<ServiceResponse<List<Book>>>> Index()
        {
            var result = await _bookService.GetBookAsync();
            return View("Index", result);
        }

        [HttpGet("AddBook")]
        public IActionResult AddBook()
        {
            return View("AddBook");
        }

        [HttpGet("BookForm")]
        public IActionResult BookForm()
        {
            return View("BookForm");
        }

        [HttpGet("DeleteBook")]
        public IActionResult DeleteBook()
        {
            return View("DeleteBook");
        }

        [HttpGet("UpdateBook")]
        public IActionResult UpdateBook()
        {
            return View("UpdateBook");
        }

        //CRUD
        [HttpPost("AddBook")]
        public async Task<ActionResult<ServiceResponse<Book>>> AddNewBook([FromBody] Book book)
        {
            var res = await _bookService.AddBookAsync(book);
            return res;
        }

        [HttpGet("GetBook")]
        public async Task<ActionResult<ServiceResponse<Book>>> GetBook(int id)
        {
            var result = await _bookService.GetBookByIDAsync(id);
            return View("GetBook", result);
        }

        [HttpDelete("DeleteBookForm")]
        public async Task<ActionResult<ServiceResponse<Book>>> DeleteBookForm([FromBody] int id)
        {
            var result = await _bookService.DeleteBookAsync(id);
            return result;
        }

        [HttpPut("UpdateBook")]
        public async Task<ActionResult<ServiceResponse<Book>>> ModificateBook([FromBody] Book book)
        {
            var result = await _bookService.UpdateBookAsync(book);
            return result;
        }
    }
}
