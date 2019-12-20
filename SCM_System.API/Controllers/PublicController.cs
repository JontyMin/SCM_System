using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SCM_System.DAL;
using SCM_System.Model;
using System.Threading.Tasks;
using SCM_System.Model.Mr_Yao;
using SCM_System.DAL.PageClass;
using System.Data.Entity;
namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/public")]
    public class PublicController : ApiController
    {
      BaseService<CustomerLevel> db = CreateFactory.CreateInstance<CustomerLevelService>();
        CustomersService cs = CreateFactory.CreateInstance<CustomersService>();
        /// <summary>
        /// 根据条件查询用户表和层级表的信息并分页
        /// </summary>
        /// <param name="cname">客户名称</param>
        /// <param name="level">层级</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCustomersUponConditionPage")]
        public async Task<MyPage<V_CustomersAndLevel>> GetCustomersUponConditionPage(string cname="输入名称", int level=0, UInt16 index = 1, UInt16 size = 3)
        {
            return await cs.uponConditionPageForCustomers(cname, level, Convert.ToInt32(index), Convert.ToInt32(size));
        }


        [HttpGet]
        [Route("GetCustomerLevelAll")]
        public Task<List<CustomerLevel>> GetCustomerLevelAll() {
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
            //db.Dispose();
           base.Dispose(disposing);
        }
    }
}
