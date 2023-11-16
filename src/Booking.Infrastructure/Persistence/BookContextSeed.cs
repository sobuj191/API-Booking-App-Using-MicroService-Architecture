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
                    Distric = "Cumilla",
                    Thana="B-Para",
                    WordNo="4 No",
                    State="Dhaka",
                    CardName="Bkash",
                    CardNumber="0125",
                    PaymentMethod=1,
                    Price=100,
                    CVV="Auto",
                    Expiration="20231025",
                    CreatedBy="Sobuj",
                    CreatedDate= DateTime.Now,
                    UpdateDate= DateTime.Now,
                    UpdatedBy="Sobuj"
                }
                ) ;
        }
    }
}
