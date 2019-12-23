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

        #region CreateObject
        //创建用户层级dal
        BaseService<CustomerLevel> db = CreateFactory.CreateInstance<CustomerLevelService>();
      //创建用户dal
        CustomersService cs = CreateFactory.CreateInstance<CustomersService>();
       //创建商品视图dal
        V_ProductsService vps = CreateFactory.CreateInstance<V_ProductsService>();
       //创建商品类型dal
        BaseService<ProductTypes> bs_pt = CreateFactory.CreateInstance<ProductTypesService>();
        //创建供货商dal
        ProductLendService pls = CreateFactory.CreateInstance<ProductLendService>();
        //创建客户订单表和客户等级表和客户表的视图
        V_CusAndCusOrderAndClvService vcoc = CreateFactory.CreateInstance<V_CusAndCusOrderAndClvService>();
        //创建报价单跟报价详情单和客户表的视图
        V_QuotePriceAndDetailAndCustomersService vqdc = CreateFactory.CreateInstance<V_QuotePriceAndDetailAndCustomersService>();
        //创建采购表和采购详情表和供货商表和用户表的视图
        V_StockAndDetailAndProLendAndUsersService vsdpu = CreateFactory.CreateInstance<V_StockAndDetailAndProLendAndUsersService>();
        #endregion

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


        /// <summary>
        /// 查询所有的客户等级信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCustomerLevelAll")]
        public Task<List<CustomerLevel>> GetCustomerLevelAll() {
            return db.GetAllAsync();
        }


        /// <summary>
        /// 根据条件查询商品视图的信息并分页
        /// </summary>
        /// <param name="pname">商品名称</param>
        /// <param name="plevel">商品类型</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [Route("GetVProductsAllAboutPage")]
        public async Task<MyPage<V_Products>> GetVProductsAllAboutPage(string pname,int plevel,UInt16 index=1,UInt16 size=3) {
            return await vps.uponConditionPageForVProducts(pname, plevel, Convert.ToInt32(index), Convert.ToInt32(size));
        }



        // <summary>
        /// 根据条件查询商品视图的信息并分页(有数量)
        /// </summary>
        /// <param name="pname">商品名称</param>
        /// <param name="plevel">商品类型</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [Route("GetVProductsAllAboutPageHaveCount")]
        public async Task<MyPage<V_VProductsAndDepotStock>> GetVProductsAllAboutPageHaveCount(string pname, int plevel, UInt16 index = 1, UInt16 size = 3)
        {
            return await vps.uponConditionPageForVProductsHaveCount(pname, plevel, Convert.ToInt32(index), Convert.ToInt32(size));
        }


        /// <summary>
        /// 得到所有的商品类型信息
        /// </summary>
        /// <returns></returns>
        [Route("GetProductTypesAll")]
        public Task<List<ProductTypes>> GetProductTypesAll() {
            return bs_pt.GetAllAsync();
        }



        /// <summary>
        /// 根据条件查询供货商的信息并分页
        /// </summary>
        /// <param name="name">供货商的名字</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProductLendsAllAboutPage")]
        public Task<MyPage<ProductLend>> GetProductLendsAllAboutPage(string name,UInt16 index=1,UInt16 size=3) {
            return pls.uponConditionPageForProductLend(name,Convert.ToInt32(index),Convert.ToInt32(size));
        }



        /// <summary>
        /// 根据条件得到V_CusAndCusOrderAndClv视图的信息并分页
        /// </summary>
        /// <param name="name">客户名称</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetV_CusAndCusOrderAndClvUponCondtionAndPage")]
        public Task<MyPage<V_CusAndCusOrderAndClv>> GetV_CusAndCusOrderAndClvUponCondtionAndPage(string name,UInt16 index=1,UInt16 size=3) {

            return vcoc.uponConditionPageFor_VCusAndCusOrderAndClv(name, Convert.ToInt32(index), Convert.ToInt32(size));
        }


        /// <summary>
        /// 根据报价单编号和客户名称对V_QuotePriceAndDetailAndCustomers视图进行分页
        /// </summary>
        /// <param name="name">客户名称</param>
        /// <param name="level">报价单编号</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetV_QuotePriceAndDetailAndCustomersUponCondtionAndPage")]
        public Task<MyPage<V_QuotePriceAndDetailAndCustomers>> GetV_QuotePriceAndDetailAndCustomersUponCondtionAndPage(string name,string level,UInt16 index = 1, UInt16 size = 3)
        {

            return vqdc.uponConditionPageForV_QuotePriceAndDetailAndCustomers(name,level,Convert.ToInt32(index), Convert.ToInt32(size));
        }



        /// <summary>
        /// 根据条件得到V_StockAndDetailAndProLendAndUsers视图的信息并分页
        /// </summary>
        /// <param name="name">创建人</param>
        /// <param name="level">供货商</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public Task<MyPage<V_StockAndDetailAndProLendAndUsers>> GetV_StockAndDetailAndProLendAndUsersPageUponCondition(string name, string level, UInt16 index = 1, UInt16 size= 3) {
            return vsdpu.uponConditionPageForV_StockAndDetailAndProLendAndUsers(name, level, Convert.ToInt32(index), Convert.ToInt32(size));
        }



        /// <summary>
        /// 得到所有个供货商信息
        /// </summary>
        /// <returns></returns>
        [Route("GetProductLendsAll")]
        public Task<List<ProductLend>> GetProductLendsAll() {
            return pls.GetAllAsync();
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
