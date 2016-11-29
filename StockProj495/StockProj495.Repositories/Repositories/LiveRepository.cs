using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using StockProj495.Entities.Models;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using System.Threading;
using Newtonsoft.Json;


namespace StockProj495.Repositories.Repositories
{
    public class LiveRepository
    {
        private readonly RestClient client = new RestClient("https://query.yahooapis.com/v1/public/");
        public IEnumerable<StockModel> Get(IEnumerable<string> symbols) 
        {
            var stocks = new List<Quote>();
            foreach (var symbol in symbols)
            {
                var request = new RestRequest("yql?q=select symbol,Ask,LastTradeDate,LastTradeTime,Change,Open,DaysHigh,DaysLow,Volume,PreviousClose,PercentChange,Name from yahoo.finance.quotes where symbol in (\"" + symbol + "\")&format=json&env=store://datatables.org/alltableswithkeys&callback=");
                var response = client.Execute(request);
                try
                {
                    var stock = SimpleJson.DeserializeObject<LiveStockModel>(response.Content);
                    stocks.Add(stock.query.results.quote);
                }
                catch (Exception e)
                {

                }
            }

            var actualStocks = new List<StockModel>();
            foreach(var stock in stocks){
                actualStocks.Add(StockModel.Map(stock));
            }
            return actualStocks;
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
