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

        public InteractiveChartModel GetChart(InteractiveChartModelInput chart)
        {
            var testChart = new InteractiveChartModelInput
            {
                Normalized = false,
                NumberOfDays = 200,
                DataPeriod = "Day",
                Elements = new List<ElementModel>{
                    new ElementModel{
                        Symbol = "AAPL",
                        Type ="price",
                        Params = new object[] {"ohlc"}
                    },
                    new ElementModel{
                        Symbol= "AAPL",
                        Type= "volume"
                    }
                }
            };
            var request = new RestRequest("InteractiveChart/json?parameters={parameters}");
            var json = HttpUtility.UrlEncodeUnicode(SimpleJson.SerializeObject(testChart).ToString());
            request.AddParameter("parameters", json, ParameterType.UrlSegment);
            var response = client.Execute(request);
            var returnChart = SimpleJson.DeserializeObject<InteractiveChartModel>(response.Content);
            return returnChart;
        }
    }
}
