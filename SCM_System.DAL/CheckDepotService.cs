using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;

namespace SCM_System.DAL
{
    public class CheckDepotService : BaseService<CheckDepot>
    {
        public CheckDepotService() : base(new db_SCM())
        {
        }
    }
}
