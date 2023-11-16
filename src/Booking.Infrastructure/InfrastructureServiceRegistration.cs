using Booking.Application.Contacts.Infrastructure;
using Booking.Application.Contacts.Persistence;
using Booking.Infrastructure.Messages;
using Booking.Infrastructure.Persistence;
using Booking.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BookDB")));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddTransient<IMessageService, MessageService>();
            return services;
        }
    } 
}
