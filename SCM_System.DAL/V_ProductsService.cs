using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;
using SCM_System.Model;
using SCM_System.Model.Mr_Yao;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace SCM_System.DAL
{
    public class V_ProductsService:BaseService<V_Products>
    {
        public V_ProductsService():base(new db_SCM()) {
        
        }

        private readonly static string strCon = ConfigurationManager.ConnectionStrings["db_SCM"].ConnectionString;
        
        /// <summary>
        /// 在商品视图里根据条件查询并且分页(没有仓库数量一列)
        /// </summary>
        /// <param name="pname"></param>
        /// <param name="plevel"></param>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public async Task<MyPage<V_Products>> uponConditionPageForVProducts(string pname, int plevel, int index = 1, int size = 3)
        {
            List<V_Products> ls = null;
            await Task.Run(() =>
            {
                ls = base._db.V_Products.ToList();
            });
            int total = ls.Count();
            if (!pname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.ProName.Contains(pname)).ToList();
            }
            if (plevel > 0)
            {
                ls = ls.Where(x => x.PTID == plevel).ToList();
            }
            ls = ls.OrderBy(x => x.ProID).Skip((index - 1) * size).Take(size).ToList();      
            return base.uponConditionPage<V_Products>(ls, total);
        }

        /// <summary>
        /// 根据条件分页对于VProducts视图并且显示库存
        /// </summary>
        /// <param name="pname">客户名称</param>
        /// <param name="plevel">客户等级</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<V_VProductsAndDepotStock>> uponConditionPageForVProductsHaveCount(string pname, int plevel, int index = 1, int size = 3)
        {
            List<V_VProductsAndDepotStock> ls = new List<V_VProductsAndDepotStock>();
            await Task.Run(() =>
            {
                using (SqlConnection con=new SqlConnection (strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from V_VProductsAndDepotStock",con);
                    SqlDataReader sd=cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        ls.Add(new V_VProductsAndDepotStock()
                        {
                            ProID = sd["ProID"].ToString(),
                            PTID =Convert.ToInt32(sd["PTID"]),
                            ProCount=Convert.ToInt32(sd["ProCount"]),
                            ProInPrice=Convert.ToDecimal( sd["ProInPrice"]),
                            ProName=sd["ProName"].ToString(),
                            ProPrice=Convert.ToDecimal(sd["ProPrice"]),
                            PTName=sd["PTName"].ToString()
                        }); 
                    }

                }
            });
            int total = ls.Count();
            if (!pname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.ProName.Contains(pname)).ToList();
            }
            if (plevel > 0)
            {
                ls = ls.Where(x => x.PTID == plevel).ToList();
            }
            ls = ls.OrderBy(x => x.ProID).Skip((index - 1) * size).Take(size).ToList();
            return base.uponConditionPage<V_VProductsAndDepotStock>(ls, total);
        }
    }
}
