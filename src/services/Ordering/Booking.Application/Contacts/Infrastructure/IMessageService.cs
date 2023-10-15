using Booking.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Contacts.Infrastructure
{
    public interface IMessageService
    {
        Task<bool> SendMessageAsync(Message message);

    }
}
