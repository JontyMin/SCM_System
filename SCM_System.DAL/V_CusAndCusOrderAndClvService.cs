using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;
using SCM_System.Model;
using SCM_System.Model.Mr_Yao;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace SCM_System.DAL
{
    public class V_CusAndCusOrderAndClvService : BaseService<V_CusAndCusOrderAndClv>
    {
        public V_CusAndCusOrderAndClvService() : base(new db_SCM()) { }

        private readonly static string strCon = ConfigurationManager.ConnectionStrings["db_SCM"].ConnectionString;
        #region 根据条件对客户订单表,订单详表和客户等级表和客户表的视图进行分页查询
        /// <summary>
        /// 对VCusAndCusOrderAndClv视图根据条件分页
        /// </summary>
        /// <param name="cname">客户名称</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<V_CusAndCusOrderAndClv>> uponConditionPageFor_VCusAndCusOrderAndClv(string cname, int index = 1, int size = 3)
        {
            List<V_CusAndCusOrderAndClv> ls = new List<V_CusAndCusOrderAndClv>();
            await Task.Run(() =>
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from V_CusAndCusOrderAndClv", con);
                    SqlDataReader sd = cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        ls.Add(new V_CusAndCusOrderAndClv()
                        {
                            CODID=Convert.ToInt32(sd["CODID"]),
                            COID = sd["COID"].ToString(),
                            CLName = sd["CLName"].ToString(),
                            CusID = sd["CusID"].ToString(),
                            CusName = sd["CusName"].ToString(),
                            CODDiscont = Convert.ToInt32(sd["CODDiscont"]),
                            CODCount = Convert.ToDecimal(sd["CODCount"])
                        });
                    }
                }
            });
            int total = ls.Count();
            if (!cname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.CusName.Contains(cname)).ToList();
            }
            ls = ls.OrderBy(x => x.CODID).Skip((index - 1) * size).Take(size).ToList();
            return base.uponConditionPage<V_CusAndCusOrderAndClv>(ls, total);
        }
        #endregion

    }
}
