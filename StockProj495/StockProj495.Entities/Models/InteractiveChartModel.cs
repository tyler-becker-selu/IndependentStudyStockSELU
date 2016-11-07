using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class InteractiveChartModel
    {
        public InteractiveChartModel()
        {
           this.Elements = new List<ElementDataModel>();
        }

        public object Labels { get; set; }
        public object Positions { get; set; }
        public object Dates { get; set; }
        public List<ElementDataModel> Elements { get; set; }
    }
}
