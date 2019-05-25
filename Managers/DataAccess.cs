using System;
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
                db.Execute("TRUNCATE TABLE quotes");
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

                           // db.Insert<Quote>(quote);

                            string sql = @"INSERT INTO quotes 
                                            (date,price,volume,equity_id, rate_of_change)
                                            VALUES (@p1,@p2,@p3,@p4,@p5)";
                            db.Execute(sql, new
                            {
                                p1 = quote.Date,
                                p2 = quote.Price,
                                p3 = quote.Volume,
                                p4 = quote.EquityId,
                                p5 = quote.RateOfChange
                            });
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
                equity = db.Query<Equity>("SELECT * FROM equities WHERE symbol = @p1", new { p1 = symbol}).FirstOrDefault();
            }

            List<Quote> quoteList = new List<Quote>();

            using (var db = new NpgsqlConnection(connString))
            {
                string sql = "SELECT * FROM quotes WHERE equity_id = @p1 AND date BETWEEN @p2 AND @p3";
                quoteList = db.Query<Quote>(sql, new { p1 = equity.Id, p2 = startDate, p3 = endDate }).ToList();             
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
                var q = db.ExecuteScalar<DateTime>("SELECT MAX(date) FROM quotes");
                return q;
            }
        }

        private static Equity BuildEquityFromSymbol(string symbol)
        {
            using (var db = new NpgsqlConnection(connString))
            {
               return db.QuerySingleOrDefault<Equity>(@"SELECT * FROM equities WHERE symbol = @p1", new { p1 = symbol } );
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
                    string sql = @"INSERT INTO quotes 
                                            (date,price,volume,equity_id, rate_of_change)
                                            VALUES (@p1,@p2,@p3,@p4,@p5)";
                    db.Execute(sql, new
                    {
                        p1 = quote.Date,
                        p2 = quote.Price,
                        p3 = quote.Volume,
                        p4 = quote.EquityId,
                        p5 = quote.RateOfChange
                    });
                }
            }
        }

        #region user methods

        public static List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            using (var db = new NpgsqlConnection(connString))
            {
               userList = db.Query<User>("SELECT * FROM users").ToList();
            }

            return userList;
        }

        public static User GetUser(string userName)
        {
            using (var db = new NpgsqlConnection(connString))
            {
                return db.QueryFirstOrDefault<User>("SELECT * FROM users WHERE user_name = @p1", new { p1 = userName });
            }

        }

        public static bool AddUser(User user)
        {
            using (var db = new NpgsqlConnection(connString))
            {
                string sql = @"INSERT INTO users 
                                (user_name, password, active)
                               VALUES (@p1, @p2, @p3)";

                int x = db.Execute(sql, new { p1 = user.UserName, p2 = user.Password, p3 = user.Active });

                return (x == 1);
            }
        }

        public static bool UpdateUser(User user)
        {
            using (var db = new NpgsqlConnection(connString))
            {
                string sql = @"UPDATE users 
                               SET user_name = @p1,
                                   password = @p2,
                                   active = @p3
                               WHERE id = @p4";

                int x = db.Execute(sql, new { p1 = user.UserName, p2 = user.Password, p3 = user.Active, p4 = user.Id });

                return (x == 1);
            }
        }

        #endregion

    }
}
