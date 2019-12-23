using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace SCM_System.DAL
{
   public class PdskcService
    {
        db_SCM db = new db_SCM();

        private static readonly string strCon = ConfigurationManager.ConnectionStrings["db_SCM"].ConnectionString;
        #region 王朋朋

        /// <summary>
        /// 查看当前库存 给据编号查询当前库存信息
        /// </summary>
        /// <param name="CDID">盘点单编号</param>
        /// <returns></returns>
        public async Task<CheckDepot> GetCheckDepotAllID(string CDID)
        {
            return await db.CheckDepot.Where(a => a.CDID == CDID).SingleAsync();
        }

        /// <summary>
        /// 当前库存 给据编号进行删除
        /// </summary>
        /// <param name="CDID">盘点单编号</param>
        /// <returns></returns>
        public async Task<int> DelCheckDepotAllID(string CDID)
        {
            var lst = await db.CheckDepot.FindAsync(CDID);
            db.Entry<CheckDepot>(lst).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges();
        }


        public async Task<List<Vw_CDU>> GetVw_CDUAll()
        {

            List<Vw_CDU> list = new List<Vw_CDU>();
            await Task.Run(()=> {
                using (SqlConnection con=new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Vw_CDU", con);
                    SqlDataReader sd = cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        list.Add(new Vw_CDU() { 
                            CDDate = Convert.ToDateTime(sd["CDDate"]),
                            CDID = sd["CDID"].ToString(),
                            CDState = Convert.ToInt32(sd["CDState"]),
                            DepotName = sd["DepotName"].ToString(),
                            UsersName = sd["UsersName"].ToString(),
                            CDDesc = sd["CDDesc"].ToString(),

                        });
                    }
                    
                }
            });
            return list;
        }

        #endregion

    }
}
