using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class InteractiveChartModelInput
    {
        public InteractiveChartModelInput(){
            this.Elements = new List<ElementModel>();
        }

        public bool Normalized { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Int32 EndOffsetDays { get; set; }
        public Int32 NumberOfDays { get; set; }
        public string DataPeriod { get; set; }
        public Int32? DataInterval { get; set; }
        public string LabelPeriod { get; set; }
        public Int32? LabelInterval { get; set; }
        public List<ElementModel> Elements { get; set; }
    }
}
