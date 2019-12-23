using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;

namespace SCM_System.DAL
{
    public class StocksService : BaseService<Stocks>
    {
        public StocksService() : base(new db_SCM())
        {

        }
    }
}
