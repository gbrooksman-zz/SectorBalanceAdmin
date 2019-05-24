﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteTool.Models;
using LiteDB;
using System.Net.Http;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using Dapper;
using Dapper.FastCrud;
using Newtonsoft.Json.Linq;


namespace QuoteTool.Managers
{
    public static class DataAccess
    {
        private static readonly HttpClient Client = new HttpClient();
        private static readonly string connString;
        private static readonly string url = $"https://api.iextrading.com/1.0/stock/market/batch?";

        static DataAccess()
        {
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["aws_postgres"].ConnectionString;

            //this is required to work corrrectly with column name annotations in the Models classes
            DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        public static void DeleteAllQuotes()
        {
            using (var db = new NpgsqlConnection(connString))
            {
                db.BulkDelete<Quote>();
            }
        }

        public static void Init()
        {

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

        public static void AddQuoteForDate(string symbol, DateTime date)
        {
            try
            {
                Equity equity = BuildEquityFromSymbol(symbol);

               string responseString = Client.GetStringAsync($"{url}symbols={symbol}&types=chart&range=1y").Result;

                using (var db = new NpgsqlConnection(connString))
                {
                    JObject quotes = JObject.Parse(responseString);
                    JArray quoteArray = (JArray)quotes[symbol]["chart"];

                    foreach (var stock in quoteArray)
                    {
                        Quote quote = BuildQuoteFromJSON(quoteArray, stock, equity);
                     
                        if (quote.Date.Date >= date.Date)
                        {
                           db.Insert(quote);
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
            Equity equity = new Equity();
            using (var db = new NpgsqlConnection(connString))
            {
                equity = db.QuerySingleOrDefault<Equity>("SELECT * FROM equities WHERE symbol = @s", symbol);
            }

            List<Quote> quoteList = new List<Quote>();

            using (var db = new NpgsqlConnection(connString))
            {
                string sql = "SELECT * FROM quotes WHERE equity_id = @eid AND date BETWEEN @d1 AND @d2";
                quoteList = db.Query<Quote>(sql, new { equity.Id, startDate, endDate }).ToList();             
            }
            return quoteList;
        }

        public static List<Equity> GetEquityList()
        {
            using (var db = new NpgsqlConnection(connString))
            { 
               return db.Query<Equity>("SELECT * FROM equities").ToList();
            }
        }

        public static int GetEquityCount()
        {
            using (var db = new NpgsqlConnection(connString))
            {
                return db.QueryFirstOrDefault<int>("SELECT count(*) FROM equities");
            }
        }

        public static DateTime GetMaxDate()
        {
            using (var db = new NpgsqlConnection(connString))
            {
                var q = db.QuerySingleOrDefault<Quote>("SELECT MAX(date) FROM quotes");
                return q.Date;
            }
        }

        private static Equity BuildEquityFromSymbol(string symbol)
        {
            using (var db = new NpgsqlConnection(connString))
            {
               return db.QuerySingleOrDefault<Equity>("SELECT * FROM equities WHERE symbol = @s", symbol);
            }
        }

        private static Quote BuildQuoteFromJSON(JArray quoteArray, JToken stock, Equity equity)
        {
            decimal priorPrice = 0;
            decimal price = decimal.Parse(stock["close"].ToString());
            var priorQuote = quoteArray.Skip(-1).FirstOrDefault();

            if (priorQuote != null)
            {
                priorPrice = decimal.Parse(priorQuote["close"].ToString());
            }

            return new Quote
                {
                    Date = DateTime.Parse(stock["date"].ToString()).Date,
                    Price = price,
                    EquityId = equity.Id,
                    Volume = int.Parse(stock["volume"].ToString()),
                    RateOfChange = CalculateRateOfChange(price, priorPrice)
                };
        }

        private static decimal CalculateRateOfChange(decimal closingPrice, decimal closingPricePrior)
        {
            return (((closingPrice - closingPricePrior) / closingPricePrior) * 100);
        }

        private static void ProcessQuoteData(string responseString, string symbol)
        {
            Equity equity = BuildEquityFromSymbol(symbol);

            using (var db = new NpgsqlConnection(connString))
            {
                JObject quotes = JObject.Parse(responseString);
                JArray quoteArray = (JArray)quotes[symbol]["chart"];

                foreach (var stock in quoteArray)
                {
                    Quote quote = BuildQuoteFromJSON(quoteArray, stock, equity);
                    db.Insert(quote);
                }
            }
        }


        public static List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            using (var db = new NpgsqlConnection(connString))
            {
               userList = db.Query<User>("SELECT user_name, password, active, id, created_at, updated_at FROM users").ToList();
            }

            return userList;
        }


    }
}
