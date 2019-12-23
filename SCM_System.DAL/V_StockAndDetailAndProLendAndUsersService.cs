using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;
using SCM_System.Model;
using SCM_System.Model.Mr_Yao;
using System.Data;
using System.Data.SqlClient;
namespace SCM_System.DAL
{
    public class V_StockAndDetailAndProLendAndUsersService:BaseService<V_StockAndDetailAndProLendAndUsers>
    {
        public V_StockAndDetailAndProLendAndUsersService():base(new db_SCM()) { 
        
        }
        private readonly static string strCon = ConfigurationManager.ConnectionStrings["db_SCM"].ConnectionString;

        /// <summary>
        /// 对V_StockAndDetailAndProLendAndUsers视图根据条件进行分页
        /// </summary>
        /// <param name="cname">创建人</param>
        /// <param name="clevel">供货商编号</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<V_StockAndDetailAndProLendAndUsers>> uponConditionPageForV_StockAndDetailAndProLendAndUsers(string cname, string clevel, int index = 1, int size = 3)
        {
            List<V_StockAndDetailAndProLendAndUsers> ls = new List<V_StockAndDetailAndProLendAndUsers>();
            await Task.Run(() =>
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from V_StockAndDetailAndProLendAndUsers", con);
                    SqlDataReader sd = cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        ls.Add(new V_StockAndDetailAndProLendAndUsers()
                        {
                            SDetailID =Convert.ToInt32(sd["SDetailID"]),
                            PPCompany = sd["PPCompany"].ToString(),
                            UsersName = sd["UsersName"].ToString(),
                            StockDate = Convert.ToDateTime(sd["StockDate"]),
                            StockInDate = Convert.ToDateTime(sd["StockInDate"]),
                            PPID=sd["PPID"].ToString(),
                            StockID=sd["StockID"].ToString(),
                            StockCount =Convert.ToDecimal(sd["StockCount"]) 
                        });
                    }

                }
            });
            int total = ls.Count();
            if (!cname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.UsersName.Contains(cname)).ToList();
            }
            if (!clevel.Equals("输入名称"))
            {
                ls = ls.Where(x => x.PPID.Equals(clevel)).ToList();
            }
            ls = ls.OrderBy(x => x.SDetailID).Skip((index - 1) * size).Take(size).ToList();       
            return base.uponConditionPage<V_StockAndDetailAndProLendAndUsers>(ls, total);
        }


    }
}
