using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace QuoteTool.Models
{
    public class Quote
    {
        public Quote() { }
        
        public string Symbol { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Volume { get; set; }

        public int Id { get; set; }
    }
}
