using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class LiveStockModel
    {
        public Query query { get; set;}
    }

    public class Query
    {
        public string count {get; set;}
        public string created { get; set; }
        public string lang { get; set; }
        public Result results { get; set; }
    }

    public class Result
    {
        public Quote quote { get; set; }
    }

    public class Quote
    {
        public string symbol { get; set; }
        public decimal Ask { get; set; }
        public string LastTradeDate { get; set; }
        public string LastTradeTime { get; set; }
        public decimal Change { get; set; }
        public decimal Open { get; set; }
        public decimal DaysHigh { get; set; }
        public decimal DaysLow { get; set; }
        public int Volume { get; set; }
        public string PercentChange { get; set; }
        public decimal PreviousClose { get; set; }
        public string Name { get; set; }
    }
}
