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
        private List<Quote> XLFQuotes = new List<Quote>();
        private List<Quote> XLKQuotes = new List<Quote>();
        private List<Quote> XLEQuotes = new List<Quote>();
        private List<Quote> XLREQuotes = new List<Quote>();
        private List<Quote> XLPQuotes = new List<Quote>();
        private List<Quote> XLVQuotes = new List<Quote>();
        private List<Quote> XLUQuotes = new List<Quote>();
        private List<Quote> XLBQuotes = new List<Quote>();
        private List<Quote> XLYQuotes = new List<Quote>();
        private List<Quote> XLIQuotes = new List<Quote>();

        public NumberCruncher()
        {
            XLKQuotes = DataAccess.FetchAllQuotes("XLK");
            XLEQuotes = DataAccess.FetchAllQuotes("XLE");
            XLPQuotes = DataAccess.FetchAllQuotes("XLP");
            XLVQuotes = DataAccess.FetchAllQuotes("XLV");
            XLUQuotes = DataAccess.FetchAllQuotes("XLU");
            XLREQuotes = DataAccess.FetchAllQuotes("XLRE");
            XLYQuotes = DataAccess.FetchAllQuotes("XLY");
            XLBQuotes = DataAccess.FetchAllQuotes("XLB");
            XLEQuotes = DataAccess.FetchAllQuotes("XLE");
            XLIQuotes = DataAccess.FetchAllQuotes("XLI");
        }



    }
}
