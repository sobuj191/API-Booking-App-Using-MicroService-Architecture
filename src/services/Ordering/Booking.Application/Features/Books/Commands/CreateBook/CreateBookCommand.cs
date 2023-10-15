using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommand:IRequest<bool>
    {
        public string UserName { get; set; }
        public decimal Price { get; set; }

        //User Address
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Distric { get; set; }
        public string Thana { get; set; }
        public string WordNo { get; set; }
        public string State { get; set; }

        //Payment Methon
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string Expiration { get; set; }
        public int PaymentMethod { get; set; }
    }
}
