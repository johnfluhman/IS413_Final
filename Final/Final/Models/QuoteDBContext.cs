using System;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class QuoteDBContext : DbContext
    {
        public QuoteDBContext (DbContextOptions<QuoteDBContext> options) : base(options)
        {

        }

        public DbSet<Quotes> submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quotes>().HasData(

                new Quotes
                {
                    QuoteID = 1,
                    Quote = "Great, kid, don't get cocky.",
                    Author = "Han Solo",
                    Date = 1977,
                    Subject = "Cinema",
                    Citation = ""
                },

                new Quotes
                {
                    QuoteID = 2,
                    Quote = "The ability to speak does not make you intelligent",
                    Author = "Qui-Gon Jinn",
                    Date = 1999,
                    Subject = "Cinema",
                    Citation = ""
                }
            );
        }
    }
}
