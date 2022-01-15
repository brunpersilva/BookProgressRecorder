using BookProgressRecorder.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookProgressRecorder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private IBookRepository _bookRepository;

        [HttpPost("GetAllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(object))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(object))]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            //var result = _bookRepository.GetAllBooks();

            var books = new List<Book>
            {
                new Book
                { 
                    Id = Guid.NewGuid(),
                    Name = "Wheel of Time"
                }
            };

            return Ok(books);
        }
    }
}
