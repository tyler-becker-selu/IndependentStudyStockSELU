using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class ElementModel
    {
        public ElementModel()
        {
            Params = new object[0];
        }

        public string Symbol { get; set; }
        public string Type { get; set; }
        public object[]  Params { get; set; }
    }
}
