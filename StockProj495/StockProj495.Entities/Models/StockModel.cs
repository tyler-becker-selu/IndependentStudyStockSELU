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
        public decimal ChangePercent { get; set; }
        public string Timestamp { get; set;}
        public decimal MSDate { get; set; }
        public double MarketCap {get; set;}
        public int Volume { get; set; }
        public decimal ChangeYTD { get; set; }
        public decimal ChangePercentYTD { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set;}
        public decimal? Close { get; set; }
    }
}
