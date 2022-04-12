using System;
using System.Linq;

namespace Final.Models
{
    public interface IQuoteRepository
    {
        IQueryable<Quotes> Quotes { get; }

        public void SaveQuote(Quotes q);
        public void CreateQuote(Quotes q);
        public void DeleteQuote(Quotes q);
    }
}
