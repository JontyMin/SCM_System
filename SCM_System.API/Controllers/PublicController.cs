using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SCM_System.DAL;
using SCM_System.Model;
using System.Threading.Tasks;


namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/public")]
    public class PublicController : ApiController
    {
       
        BaseService<Customers> db = CreateFactory.CreateInstance<CustomersService>();
        /// <summary>
        /// 查询用户表的所有信息
        /// </summary>
        /// <returns></returns>
        [Route("GetCustomersAll")]
        public Task<List<Customers>> GetCustomersAll() {       
            return db.GetAllAsync();
        }

        /// <summary>
        /// 这是预请求
        /// </summary>
        public void Options() { }


        /// <summary>
        /// 释放
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
