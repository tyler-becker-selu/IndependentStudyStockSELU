using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using StockProj495.Entities.Models;
using RestSharp;
using RestSharp.Extensions.MonoHttp;


namespace StockProj495.Repositories.Repositories
{
    public class LiveRepository : IRepository<StockModel>
    {
        private readonly RestClient client = new RestClient("http://dev.markitondemand.com/MODApis/Api/v2/");
        public IEnumerable<StockModel> Get(IEnumerable<string> symbols) 
        {
            var stocks = new List<StockModel>();
            foreach (string symbol in symbols)
            {
                var request = new RestRequest("Quote/json?symbol={symbol}");
                request.AddParameter("symbol", symbol, ParameterType.UrlSegment);
                var response = client.Execute(request);
                var stock = SimpleJson.DeserializeObject<StockModel>(response.Content);
                stocks.Add(stock);
            }

            return stocks;
        }

        public object GetChart(object chart)
        {/*
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
            var request = new RestRequest("InteractiveChart/json?parameters={parameters}");
            var json = SimpleJson.SerializeObject(testChart);
            request.AddParameter("parameters", json, ParameterType.UrlSegment);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
