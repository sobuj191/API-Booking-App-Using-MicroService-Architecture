using Booking.Application.Features.Books.Commands.CreateBook;
using Booking.Application.Features.Books.Commands.DeleteBook;
using Booking.Application.Features.Books.Commands.UpdateBook;
using Booking.Application.Features.Books.Queries.GetBookByUserName;
using CoreApiResponse;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Booking.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : BaseController
    {
        IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetBookByUserNameModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult>GetBookByUserName(string userName)
        {
            try
            {
                var result = await _mediator.Send(new GetBookByUserNameQuery(userName));
                return CustomResult("Book succesfully", result);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateBook(CreateBookCommand bookCommand)
        {
            try
            {
                var result = await _mediator.Send(bookCommand);
                if (result)
                {
                    return CustomResult("Book succesfully");
                }
                return CustomResult("Book failed", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateBook(UpdateBookCommand bookCommand)
        {
            try
            {
                var isUpdateBook = await _mediator.Send(bookCommand);
                if (isUpdateBook)
                {
                    return CustomResult("Book has been updated");
                }
                return CustomResult("Book updated failed", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }
        [HttpDelete]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBook(int bookId)
        {
            try
            {
                var isDeleteBook = await _mediator.Send(new DeleteBookCommand() { Id=bookId});
                if (isDeleteBook)
                {
                    return CustomResult("Book deletion has been deleted");
                }
                return CustomResult("Book deletion failed", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return CustomResult(ex.Message, HttpStatusCode.BadRequest);
            }
        }
    }
}
