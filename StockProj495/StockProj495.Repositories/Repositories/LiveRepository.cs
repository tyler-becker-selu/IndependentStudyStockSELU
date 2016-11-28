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
    public class LiveRepository : IRepository<StockModel>
    {
        private readonly RestClient client = new RestClient("http://ws.cdyne.com/delayedstockquote/delayedstockquote.asmx/");
        public IEnumerable<StockModel> Get(IEnumerable<string> symbols) 
        {
            var xmlDeserializer = new RestSharp.Deserializers.XmlDeserializer();
            var stocks = new List<LiveStockModel>();
            foreach (var symbol in symbols)
            {
                var request = new RestRequest("GetQuote", Method.POST);
                request.AddParameter("StockSymbol", symbol);
                request.AddParameter("LicenseKey", 0);
                var response = client.Execute(request);
                try
                {
                    var stock = xmlDeserializer.Deserialize<LiveStockModel>(response);
                    stocks.Add(stock);
                }
                catch (Exception e)
                {

                }
            }

            var actualStock = new List<StockModel>();
            foreach (var stock in stocks)
            {
                var itm = StockModel.Map(stock);
                actualStock.Add(itm);
            }
        
            return actualStock;
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
