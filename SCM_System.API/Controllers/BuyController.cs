using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SCM_System.Model;
using SCM_System.DAL;
using SCM_System.IDAL;


namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/Buy")]
    public class BuyController : ApiController,IDisposable
    {
        BaseService<Stocks> db = CreateFactory.CreateInstance<StocksService>();

        BaseService<DepotStock> db1 = CreateFactory.CreateInstance<DepotStockService>();

        db_SCM d = new db_SCM();
        [HttpGet]
        [Route("GetStocks")]

        public async Task<List<Stocks>> GetStocks()
        {
            return await db.GetAllAsync();
        }

        [HttpGet]
        [Route("GetStocksDetail/{sid}")]

        public StockDetail GetStocksDetail(string sid)
        {
            var s = d.StockDetail.Where(c => c.StockID.Equals(sid)).Single();
            return s;
        }



        [HttpDelete]
        [Route("DelStocks")]

        public async Task<int> DelStocks(Stocks s)
        {
            return await db.RemoveAsync(s);
        }

        [HttpGet]
        [Route("GetDepotStocks")]

        public async Task<List<DepotStock>> GetDepotStocks()
        {
            return await db1.GetAllAsync();
        }
    }
}
