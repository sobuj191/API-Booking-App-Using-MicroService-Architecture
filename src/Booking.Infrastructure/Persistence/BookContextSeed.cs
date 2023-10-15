using Booking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure.Persistence
{
    public class BookContextSeed
    {
        public static async Task Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>().HasData(
                new BookModel()
                {
                    Id = 1,
                    UserName = "mdsobujcmt@gmail.com",
                    FirstName = "Md.",
                    LastName = "Sobuj",
                    Email = "mdsobujcmt@gmail.com",
                    PhoneNumber = "1234567890",
                    State="Dhaka",
                    Price=100,
                }
                ) ;
        }
    }
}
