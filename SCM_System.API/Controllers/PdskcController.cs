using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using SCM_System.DAL;
using SCM_System.IDAL;
using SCM_System.Model;

namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/pdskc")]
    public class PdskcController : ApiController, IDisposable
    {
        db_SCM d = new db_SCM();
        BaseService<CheckDepot> db = CreateFactory.CreateInstance<CheckDepotService>();

        [HttpGet]
        [Route("A")]
        public async Task<List<CheckDepot>> A() {
            return await db.GetAllAsync();
        }
        

        [HttpGet]
        [Route("SeleCheckDepotID/{CDID}")]
        public List<CheckDepot> SeleCheckDepotID(string CDID)
        {
            return d.CheckDepot.Where(a=>a.CDID == CDID).ToList();
        }

        [HttpGet]
        [Route("DelCheckDepot/{ls}")]
        public int DelCheckDepot(string ls)
        {
            var lst = d.CheckDepot.Find(ls);
            d.Entry<CheckDepot>(lst).State = System.Data.Entity.EntityState.Deleted;
            return d.SaveChanges() >= 0 ? 1 : 0;

        }

        [HttpGet]
        [Route("C")]
        public int C()
        {

            if (d.CheckDepot != null)
            {
                return 1;
            }
            else {
                return 0;
            }
        }
    }
}
