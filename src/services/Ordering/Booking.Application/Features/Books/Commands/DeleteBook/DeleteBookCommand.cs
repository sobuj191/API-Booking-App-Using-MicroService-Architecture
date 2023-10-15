using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Commands.DeleteBook
{
    public class DeleteBookCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
