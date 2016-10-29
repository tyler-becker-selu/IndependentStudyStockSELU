using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockProj495.Entities.Models;
using RestSharp;


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
    }
}
