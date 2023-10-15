using Booking.Domain.Models;
using EF.Core.Repository.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Contacts.Persistence
{
    public interface IBookRepository:ICommonRepository<BookModel>
    {
        Task<IEnumerable<BookModel>> GetBookByUserName(string userName);
    }
}
