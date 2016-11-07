using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class ElementDataModel
    {
        public string Currency { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Symbol { get; set; }
        public ElementType Type { get; set; }
        public object DataSeries { get; set; }

        public enum ElementType { 
            price,
            volume,
            sma
        };
    }
}
