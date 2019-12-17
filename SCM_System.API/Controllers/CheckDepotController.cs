﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using SCM_System.DAL;
using SCM_System.IDAL;
using SCM_System.Model;
namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/CheckDepot")]
    public class CheckDepotController : ApiController,IDisposable
    {
        BaseService<CheckDepot> db=new CheckDepotService();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public async Task<List<CheckDepot>> getAll()
        {
            return await db.GetAllAsync();
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
