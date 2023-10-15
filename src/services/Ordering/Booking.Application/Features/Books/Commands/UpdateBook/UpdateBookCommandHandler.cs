using AutoMapper;
using Booking.Application.Contacts.Persistence;
using Booking.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, bool>
    {
        IBookRepository _bookRepository;
        IMapper _mapper;
        public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;

        }
        public async Task<bool> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var order=_mapper.Map<BookModel>(request);
            return await _bookRepository.UpdateAsync(order);
        }
    }
}
