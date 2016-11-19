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
    public class StockController : ApiController
    {
        private readonly HistoryRepository _repository = new HistoryRepository();
        // GET: api/Stock
        public IEnumerable<string> Get()
        {
            return _repository.GetAllAvailableSymbols();
        }

    }
}
