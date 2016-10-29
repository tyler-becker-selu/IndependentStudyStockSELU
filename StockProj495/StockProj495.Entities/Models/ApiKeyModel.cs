using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class ApiKeyModel
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public string AccessToken { get; set; }
        public string ClientSecret { get; set; }
    }
}
