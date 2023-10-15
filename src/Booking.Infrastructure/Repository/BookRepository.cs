using Booking.Application.Contacts.Persistence;
using Booking.Domain.Models;
using Booking.Infrastructure.Persistence;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure.Repository
{
    public class BookRepository : CommonRepository<BookModel>, IBookRepository
    {
        BookDbContext _dbContext;
        public BookRepository(BookDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task<IEnumerable<BookModel>> GetBookByUserName(string userName)
        {
            var bookUser=await _dbContext.books.Where(x=>x.UserName.ToLower() == userName.ToLower()).ToListAsync();
            return bookUser;
        }
    }
}
