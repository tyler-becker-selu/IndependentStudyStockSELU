using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockProj495.Entities.Models;
using RestSharp;

namespace StockProj495.Repositories.Repositories
{
    public class HistoryRepository
    {
        private readonly RestClient client = new RestClient("https://www.quandl.com/api/v3/datatables/WIKI/");
        public string Get(string date)
        {
            var request = new RestRequest("PRICES.json?date={date}&qOpts.columns=ticker,high,low,open,close,volume,date&api_key=b5srauHe8i1th1D4FK18");
            request.AddParameter("date", date, ParameterType.UrlSegment);
            var response = client.Execute(request);
            var stocks = response.Content;
            
            return stocks;
        }
    }
}
