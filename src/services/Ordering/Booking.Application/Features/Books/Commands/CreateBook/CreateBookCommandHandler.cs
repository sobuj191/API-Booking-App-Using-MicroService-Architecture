using AutoMapper;
using Booking.Application.Contacts.Infrastructure;
using Booking.Application.Contacts.Persistence;
using Booking.Application.Models;
using Booking.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, bool>
    {
        IBookRepository _bookRepository;
        IMapper _mapper;
        IMessageService _messageService;
        public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper, IMessageService messageService)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _messageService = messageService;
        }
        public async Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<BookModel>(request);
            bool isBookPlaced= await _bookRepository.AddAsync(order);
            if (isBookPlaced)
            {
                Message message = new Message();
                message.Subject = "Your booked has been placed";
                message.To = order.UserName;
                message.Body = $"Dear {order.FirstName + " " + order.LastName} <br/><br/> We are excited for your booking Kazi; your booking Id #{order.Id} <br/> Thank your for your booking ";
                await _messageService.SendMessageAsync(message);
            }
            return isBookPlaced;
        }
    }
}
