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
        BaseService<CheckDepot> db = CreateFactory.CreateInstance<CheckDepotService>();

        [HttpGet]
        [Route("A")]
        public async Task<List<CheckDepot>> A() {
            return await db.GetAllAsync();
        }

        [HttpGet]
        [Route("b")]
        public int b()
        {
            return  1;
        }
    }
}
