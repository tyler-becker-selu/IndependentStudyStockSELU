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
        // GET: api/Stock
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Stock/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
