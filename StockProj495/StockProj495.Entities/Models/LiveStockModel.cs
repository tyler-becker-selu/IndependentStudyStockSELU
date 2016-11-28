using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class LiveStockModel
    {
        public string StockSymbol { get; set; }
        public decimal LastTradeAmount { get; set; } 
        public DateTime LastTradeDateTime { get; set; }
        public decimal StockChange { get; set; }
        public decimal OpenAmount { get; set; }
        public decimal DayHigh { get; set; }
        public decimal DayLow { get; set; }
        public int StockVolume { get; set; }
        public decimal PrevCls { get; set; }
        public string ChangePercent { get; set; }
        public string FiftyTwoWeekRange { get; set; }
        public decimal EarnPerShare { get; set; }
        public decimal PE { get; set; }
        public string CompanyName { get; set; }
        public bool QuoteError { get; set; }
        public int AverageDailyVolume { get; set; }
    }
}
