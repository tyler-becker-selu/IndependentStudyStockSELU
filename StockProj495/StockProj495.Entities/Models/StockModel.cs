using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class StockModel
    {
        public string Name { get; set; }
        public string Symbol {get; set;}
        public decimal LastPrice { get; set; }
        public decimal Change { get; set; }
        public string ChangePercent { get; set; }
        public string Timestamp { get; set;}
        public int Volume { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set;}
        public decimal? Close { get; set; }

        public static StockModel Map(Quote stock)
        {
            DateTime exactTradeTime = Convert.ToDateTime(stock.LastTradeDate + " " + stock.LastTradeTime);
            var stockModel = new StockModel
            {
                Symbol = stock.symbol,
                Volume = stock.Volume,
                Name = stock.Name,  
                LastPrice = stock.Ask,
                Change = stock.Change,
                ChangePercent = stock.PercentChange,
                Timestamp = exactTradeTime.ToString(),
                High = stock.DaysHigh,
                Low = stock.DaysLow,
                Open = stock.Open,
                Close = stock.PreviousClose
            };

            return stockModel;
        }
    }
}
