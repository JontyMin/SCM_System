using SCM_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.DAL
{
    public class CheckDepotDetailService : BaseService<CheckDepotDetail>
    {
        public CheckDepotDetailService() : base(new db_SCM())
        {
        }
    }
}
