using AutoMapper;
using Booking.Application.Contacts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Queries.GetBookByUserName
{
    public class GetBookByUserNameHandler : IRequestHandler<GetBookByUserNameQuery, List<GetBookByUserNameModel>>
    {
        IBookRepository _bookRepository;
        IMapper _mapper;
        public GetBookByUserNameHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository= bookRepository;
            _mapper= mapper;
        }
        public async Task<List<GetBookByUserNameModel>> Handle(GetBookByUserNameQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetBookByUserName(request.UserName);
            return _mapper.Map<List<GetBookByUserNameModel>>(books);
        }
    }
}
