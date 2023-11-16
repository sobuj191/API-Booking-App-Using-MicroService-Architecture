using Booking.Application.Contacts.Infrastructure;
using Booking.Application.Models;
using QuickMailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure.Messages
{
    public class MessageService : IMessageService
    {
        public async Task<bool> SendMessageAsync(Message message)
        {
            Email email = new Email();
            if (email.IsValidEmail(message.To))
            {
                return email.SendEmail(message.To, MessageCredential.EmailAddress, MessageCredential.AppPassword, message.Subject, message.Body);
            }
            return false;
        }
    }
}
