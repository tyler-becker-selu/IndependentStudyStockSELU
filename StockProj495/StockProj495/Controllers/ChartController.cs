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

        public object Get([FromUri]object chart)
        {
            return _repository.GetChart(chart);
        }
    }
}
