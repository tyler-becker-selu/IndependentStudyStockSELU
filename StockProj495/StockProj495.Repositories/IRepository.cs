using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProj495.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(IEnumerable<string> symbols);
    }
}
