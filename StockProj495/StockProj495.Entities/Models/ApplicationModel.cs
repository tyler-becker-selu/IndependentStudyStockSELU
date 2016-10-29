using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Entities.Models
{
    public class ApplicationModel
    {
        public ApplicationModel()
        {
             this.Users = new List<UserModel>();
        }

        public int Id {get; set;}
        public string ApplicationName { get; set; }
        public string AccessToken { get; set; }
        public string ApplicationSecret { get; set; }
        public IEnumerable<UserModel> Users { get; set; }
    }
}
