using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using StockProj495.Entities.Models;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System.Threading;


namespace StockProj495.Repositories.Repositories
{
    public class LiveRepository : IRepository<StockModel>
    {
        private readonly RestClient client = new RestClient("http://dev.markitondemand.com/MODApis/Api/v2/");
        public IEnumerable<StockModel> Get(IEnumerable<string> symbols) 
        {
            var stocks = new List<StockModel>();
            int index = 1;
            foreach (string symbol in symbols)
            {
                if (index > 4)
                {
                   Thread.Sleep(1000);
                   index = 1;
                }
                var request = new RestRequest("Quote/json?symbol={symbol}");
                request.AddParameter("symbol", symbol, ParameterType.UrlSegment);
                var response = client.Execute(request);
                var stock = SimpleJson.DeserializeObject<StockModel>(response.Content);
                stocks.Add(stock);
                index++;
            }

            return stocks;
        }

        public object GetChart(object chart)
        {
            var request = new RestRequest("InteractiveChart/json?parameters={parameters}");
            var json = SimpleJson.SerializeObject(chart);
            request.AddParameter("parameters", json, ParameterType.UrlSegment);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
