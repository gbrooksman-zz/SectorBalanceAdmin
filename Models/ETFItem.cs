using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteTool.Models
{
    public class ETFItem
    {

        public ETFItem()
        {

        }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }

    public static class ActiveList
    {
        public static List<ETFItem> Symbols { get; } = new List<ETFItem>()
        {
            new ETFItem() { Symbol = "XLF", Name = "Financial" },
            new ETFItem() { Symbol = "XLK", Name = "Technology" },
            new ETFItem() { Symbol = "XLP", Name = "Consumer Staples" },
            new ETFItem() { Symbol = "XLV", Name = "Health Care" },
            new ETFItem() { Symbol = "XLU", Name = "Utilities" },
            new ETFItem() { Symbol = "XLRE", Name = "Real Estate" },
            new ETFItem() { Symbol = "XLY", Name = "Consumer Discretionary" },
            new ETFItem() { Symbol = "XLB", Name = "Materials" },
            new ETFItem() { Symbol = "XLE", Name = "Energy" },
            new ETFItem() { Symbol = "XLI", Name = "Industrial" }
        };
    }       
}
