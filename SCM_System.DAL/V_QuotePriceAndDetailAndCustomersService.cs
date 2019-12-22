using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
using SCM_System.Model.Mr_Yao;
using System.Data;
using System.Data.SqlClient;
using SCM_System.DAL.PageClass;
using System.Configuration;
namespace SCM_System.DAL
{
   public class V_QuotePriceAndDetailAndCustomersService:BaseService<V_QuotePriceAndDetailAndCustomers>
    {
        public V_QuotePriceAndDetailAndCustomersService():base(new db_SCM()) {
        
        
        }
        private readonly static string strCon = ConfigurationManager.ConnectionStrings["db_SCM"].ConnectionString;

        /// <summary>
        /// 根据条件对V_QuotePriceAndDetailAndCustomers视图分页
        /// </summary>
        /// <param name="pname">客户名称</param>
        /// <param name="plevel">报价订单编号</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<V_QuotePriceAndDetailAndCustomers>> uponConditionPageForV_QuotePriceAndDetailAndCustomers(string pname, string plevel, int index = 1, int size = 3)
        {
            List<V_QuotePriceAndDetailAndCustomers> ls = new List<V_QuotePriceAndDetailAndCustomers>();
            await Task.Run(() =>
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from V_QuotePriceAndDetailAndCustomers", con);
                    SqlDataReader sd = cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        ls.Add(new V_QuotePriceAndDetailAndCustomers()
                        {
                            CusID = sd["CusID"].ToString(),
                            CusName = sd["CusName"].ToString(),
                            QPID = sd["QPID"].ToString(),
                            QPDID = Convert.ToInt32(sd["QPDID"]),
                            QPDDiscont = Convert.ToInt32(sd["QPDDiscont"]),
                            QPDCount = Convert.ToDecimal(sd["QPDCount"])
                        });
                    }

                }
            });
            int total = ls.Count();
            if (!pname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.CusName.Contains(pname)).ToList();
            }
            if (!plevel.Equals("输入名称"))
            {
                ls = ls.Where(x => x.QPID.Contains(plevel)).ToList();
            }
            ls = ls.OrderBy(x => x.QPDID).Skip((index - 1) * size).Take(size).ToList();
            return base.uponConditionPage<V_QuotePriceAndDetailAndCustomers>(ls, total);
        }
    }
}
