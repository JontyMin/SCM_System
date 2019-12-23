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
        PdskcService dal = new PdskcService();
        BaseService<CheckDepot> db = CreateFactory.CreateInstance<CheckDepotService>();


        #region 王朋朋

        /// <summary>
        /// 查询当前所有库存
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCheckDepotAll")]
        public async Task<List<Vw_CDU>> GetCheckDepotAll()
        {
            return await dal.GetVw_CDUAll();
        }


        /// <summary>
        /// 查看当前库存 给据编号查询当前库存信息
        /// </summary>
        /// <param name="CDID">盘点单编号</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCheckDepotAllID/{CDID}")]
        public async Task<CheckDepot> GetCheckDepotAllID(string CDID)
        {
            return await dal.GetCheckDepotAllID(CDID);
        }


        /// <summary>
        /// 当前库存根据编号删除 
        /// </summary>
        /// <param name="ls">盘点单编号</param>
        /// <returns></returns>
        [HttpGet]
        [Route("DelCheckDepotAllID/{ls}")]
        public async Task<int> DelCheckDepotAllID(string ls)
        {
            return await dal.DelCheckDepotAllID(ls);

        }

        #endregion


    }
}
