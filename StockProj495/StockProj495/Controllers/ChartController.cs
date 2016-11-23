using StockProj495.Entities.Models;
using StockProj495.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StockProj495.Controllers
{
    public class ChartController : ApiController
    {
        private readonly LiveRepository _repository = new LiveRepository();

        public object Get([FromBody]object chart)
        {
            /*
            var testChart = new
            {
                Normalized = false,
                NumberOfDays = 200,
                DataPeriod = "Day",
                Elements = new List<object>{
                    new {
                        Symbol = "AAPL",
                        Type ="price",
                        Params = new object[] {"ohlc"}
                    },
                    new {
                        Symbol= "AAPL",
                        Type= "volume"
                    }
                }
            };*/
            return _repository.GetChart(chart);
        }
    }
}
