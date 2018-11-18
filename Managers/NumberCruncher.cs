using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using QuoteTool.Models;

namespace QuoteTool.Managers
{
    public class NumberCruncher
    {
        private readonly List<Quote> XLFQuotes = new List<Quote>();
        private readonly List<Quote> XLKQuotes = new List<Quote>();
        private readonly List<Quote> XLEQuotes = new List<Quote>();
        private readonly List<Quote> XLREQuotes = new List<Quote>();
        private readonly List<Quote> XLPQuotes = new List<Quote>();
        private readonly List<Quote> XLVQuotes = new List<Quote>();
        private readonly List<Quote> XLUQuotes = new List<Quote>();
        private readonly List<Quote> XLBQuotes = new List<Quote>();
        private readonly List<Quote> XLYQuotes = new List<Quote>();
        private readonly List<Quote> XLIQuotes = new List<Quote>();

        public NumberCruncher(DateTime startDate, DateTime endDate)
        {
            XLKQuotes = DataAccess.LookupAllQuotes("XLK", startDate, endDate);
            XLEQuotes = DataAccess.LookupAllQuotes("XLE", startDate, endDate);
            XLPQuotes = DataAccess.LookupAllQuotes("XLP", startDate, endDate);
            XLVQuotes = DataAccess.LookupAllQuotes("XLV", startDate, endDate);
            XLUQuotes = DataAccess.LookupAllQuotes("XLU", startDate, endDate);
            XLREQuotes = DataAccess.LookupAllQuotes("XLRE", startDate, endDate);
            XLYQuotes = DataAccess.LookupAllQuotes("XLY", startDate, endDate);
            XLBQuotes = DataAccess.LookupAllQuotes("XLB", startDate, endDate);
            XLEQuotes = DataAccess.LookupAllQuotes("XLF", startDate, endDate);
            XLIQuotes = DataAccess.LookupAllQuotes("XLI", startDate, endDate);
        }

        public void CompareQuoteHistory(List<string> symbolList)
        {
            

        }

    }
}
