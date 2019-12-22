using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;
using SCM_System.Model;
using SCM_System.Model.Mr_Yao;
using System.Data.Entity;
namespace SCM_System.DAL
{
    public class CustomersService : BaseService<Customers>
    {
        public CustomersService():base(new db_SCM()) { 
        
        }
        /// <summary>
        /// 对用户表根据条件进行分页查询
        /// </summary>
        /// <param name="cname">用户名</param>
        /// <param name="clevel">用户等级</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<V_CustomersAndLevel>> uponConditionPageForCustomers(string cname,int clevel,int index=1,int size=3) {
            List<V_CustomersAndLevel> ls = null ;
            await Task.Run(() =>
            {
                ls = base._db.Customers.Join(base._db.CustomerLevel, c => c.CLID, l => l.CLID,
                    (c, l) => new V_CustomersAndLevel() { CusID = c.CusID, CLID = c.CLID, CusName = c.CusName, CusCompany = c.CusCompany, CusMan = c.CusMan, CusDesc = c.CusDesc, CLName = l.CLName, CLAgio = l.CLAgio }).ToList() as List<V_CustomersAndLevel>;
            });
            int total = ls.Count();
            //await Task.Run(() =>
            //{
                if (!cname.Equals("输入名称"))
                {
                    ls = ls.Where(x => x.CusName.Contains(cname)).ToList();
                }
                if (clevel > 0)
                {
                    ls = ls.Where(x => x.CLID == clevel).ToList();
                }
                ls = ls.OrderBy(x => x.CusID).Skip((index - 1) * size).Take(size).ToList();
            //});        
            return base.uponConditionPage<V_CustomersAndLevel>(ls,total);
        }
    
    }
}
