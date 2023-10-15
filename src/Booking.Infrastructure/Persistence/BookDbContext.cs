using Booking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure.Persistence
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext>Options):base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BookContextSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<BookModel> books { get; set; }
    }
}
