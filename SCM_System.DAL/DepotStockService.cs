using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;

namespace SCM_System.DAL
{
    public class DepotStockService : BaseService<DepotStock>
    {
        public DepotStockService() : base(new db_SCM())
        {

        }
    }
}
