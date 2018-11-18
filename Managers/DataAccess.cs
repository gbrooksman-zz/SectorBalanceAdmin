using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteTool.Models;
using LiteDB;
using System.Net.Http;
using Newtonsoft.Json;

namespace QuoteTool.Managers
{
    using Newtonsoft.Json.Linq;
    using System;


    public static class DataAccess
    {
        private static readonly HttpClient Client = new HttpClient();

        private static readonly string dbPath = @"C:\Users\geoff\source\repos\QuoteTool\QuoteTool\Data\quote_tool.db";
        private static readonly string url = $"https://api.iextrading.com/1.0/stock/market/batch?";

        public static void ClearData()
        {
            using (var db = new LiteDatabase(dbPath))
            {
                db.DropCollection("quotes");
            }
        }

        public static void Init()
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");
                quoteColl.EnsureIndex(x => x.Symbol);
                quoteColl.EnsureIndex(x => x.Date);
            }
        }
        
        public static void FetchFiveYearQuotes(string symbol)
        {                
            try
            {
                string responseString = Client.GetStringAsync($"{url}symbols={symbol}&types=chart&range=5y").Result;
                ProcessQuoteData(responseString, symbol);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GetDayQuote(string symbol)
        {
            try
            {
                string responseString = Client.GetStringAsync($"{url}symbols={symbol}&types=chart&range=1d").Result;
                ProcessQuoteData(responseString, symbol);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GetDateQuote(string symbol, DateTime date)
        {
            try
            {
                string responseString = Client.GetStringAsync($"{url}symbols={symbol}&types=chart&range=1y").Result;

                using (var db = new LiteDatabase(dbPath))
                {
                    var quoteColl = db.GetCollection<Quote>("quotes");

                    JObject quotes = JObject.Parse(responseString);
                    JArray quoteArray = (JArray)quotes[symbol]["chart"];

                    foreach (var stock in quoteArray)
                    {
                        Quote quote = new Quote
                        {
                            Date = DateTime.Parse(stock["date"].ToString()).Date,
                            Price = decimal.Parse(stock["close"].ToString()),
                            Symbol = symbol,
                            Volume = stock["volume"].ToString()
                        };

                        if (quote.Date.Date >= date.Date)
                        {
                            quoteColl.Insert(quote);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Quote> LookupAllQuotes(string symbol, DateTime startDate, DateTime endDate)
        {
            List<Quote> quoteList = new List<Quote>();
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");
                quoteList = quoteColl.Find(q => q.Symbol == symbol
                                            && q.Date >= startDate 
                                            && q.Date <= endDate)
                                            .OrderBy(q => q.Date)
                                            .ToList();
            }
            return quoteList;
        }

        public static DateTime GetMaxDate()
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");
                return quoteColl.Max(q => q.Date).AsDateTime;
            }
        }

        private static void ProcessQuoteData(string responseString, string name)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");

                JObject quotes = JObject.Parse(responseString);
                JArray quoteArray = (JArray)quotes[name]["chart"];

                foreach (var stock in quoteArray)
                {
                    Quote quote = new Quote
                    {
                        Date = DateTime.Parse(stock["date"].ToString()).Date,
                        Price = decimal.Parse(stock["close"].ToString()),
                        Symbol = name,
                        Volume = stock["volume"].ToString()
                    };

                    quoteColl.Insert(quote);
                }
            }
        }
    }
}
