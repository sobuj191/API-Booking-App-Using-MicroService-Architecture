using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommandValidation : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidation()
        {
            RuleFor(c=>c.UserName).NotEmpty().WithMessage("Please Enter Name").EmailAddress().WithMessage("User name should be valid email");
            RuleFor(c=>c.FirstName).NotEmpty().WithMessage("Please Enter First Name").MaximumLength(100).WithMessage("First name must not exceed 100 character");
            RuleFor(c=>c.Price).GreaterThan(0).WithMessage("Price should be grather than 0");
            RuleFor(c=>c.Email).EmailAddress().WithMessage("EmailAddresss should be valid email address");
        }
    }
}
