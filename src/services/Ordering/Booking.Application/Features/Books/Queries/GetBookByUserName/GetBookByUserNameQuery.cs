using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Queries.GetBookByUserName
{
    public class GetBookByUserNameQuery:IRequest<List<GetBookByUserNameModel>>
    {
        public string UserName { get; set; }
        public GetBookByUserNameQuery(string userName) { 
        UserName=userName;
        }
    }
}
