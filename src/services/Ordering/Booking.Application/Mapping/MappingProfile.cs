using AutoMapper;
using Booking.Application.Features.Books.Commands.CreateBook;
using Booking.Application.Features.Books.Commands.UpdateBook;
using Booking.Application.Features.Books.Queries.GetBookByUserName;
using Booking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookModel, GetBookByUserNameModel>().ReverseMap();
            CreateMap<BookModel, CreateBookCommand>().ReverseMap();
            CreateMap<BookModel, UpdateBookCommand>().ReverseMap();
        }
    }
}
