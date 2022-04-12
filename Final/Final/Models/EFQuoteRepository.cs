using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class EFQuoteRepository : IQuoteRepository
    {
        private QuoteDBContext context { get; set; }

        public EFQuoteRepository (QuoteDBContext temp)
        {
            context = temp;
        }

        public IQueryable<Quotes> Quotes => context.submissions;

        public void SaveQuote(Quotes q)
        {
            context.submissions.Update(q);
            context.Entry(q).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void CreateQuote(Quotes q)
        {
            context.Add(q);
            context.SaveChanges();
        }

        public void DeleteQuote(Quotes q)
        {
            context.Remove(q);
            context.SaveChanges();
        }

    }
}
