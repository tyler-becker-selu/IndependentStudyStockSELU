using System;
using System.Collections.Generic;
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

        public static StockModel Map(LiveStockModel stock)
        {
            var stockModel = new StockModel
            {
                Symbol = stock.StockSymbol,
                Volume = stock.StockVolume,
                Name = stock.CompanyName,  
                LastPrice = stock.LastTradeAmount,
                Change = stock.StockChange,
                ChangePercent = stock.ChangePercent,
                Timestamp = stock.LastTradeDateTime.ToString(),
                High = stock.DayHigh,
                Low = stock.DayLow,
                Open = stock.OpenAmount,
                Close = stock.PrevCls
            };

            return stockModel;
        }
    }
}
