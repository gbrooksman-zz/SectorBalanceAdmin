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

        public static void FetchFiveYearQuotes(string name)
        {                
            try
            {
                string responseString = Client.GetStringAsync($"{url}symbols={name}&types=chart&range=5y").Result;
                ProcessQuoteData(responseString,name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GetDayQuote(string name)
        {
            try
            {
                string responseString = Client.GetStringAsync($"{url}symbols={name}&types=chart&range=1d").Result;
                ProcessQuoteData(responseString, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<Quote> FetchAllQuotes(string name, DateTime startDate, DateTime endDate)
        {
            List<Quote> quoteList = new List<Quote>();
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");
                quoteList = quoteColl.Find(q => q.Symbol == name 
                                            && q.Date >= startDate 
                                            && q.Date <= endDate)
                                            .OrderBy(q => q.Date)
                                            .ToList();
            }
            return quoteList;
        }

        private static void ProcessQuoteData(string responseString, string name)
        {
            using (var db = new LiteDatabase(dbPath))
            {
                var quoteColl = db.GetCollection<Quote>("quotes");
                quoteColl.EnsureIndex(x => x.Symbol);

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
