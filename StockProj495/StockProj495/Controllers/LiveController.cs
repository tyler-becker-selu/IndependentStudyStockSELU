using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StockProj495.Repositories.Repositories;
using StockProj495.Entities.Models;

namespace StockProj495.Controllers
{
    public class LiveController : ApiController
    {
        private readonly LiveRepository _repository = new LiveRepository();
        // GET: api/LiveStock
        public IEnumerable<StockModel> Get([FromUri]IEnumerable<string> symbols)
        {
            return _repository.Get(symbols);
        }

        [Route("Live/{ticker}/chart")]
        public InteractiveChartModel Get()
        {
            return null;
        }

    }
}
