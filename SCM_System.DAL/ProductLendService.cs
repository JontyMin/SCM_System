using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.DAL.PageClass;
using SCM_System.Model;
namespace SCM_System.DAL
{
    public class ProductLendService:BaseService<ProductLend>
    {
        public ProductLendService():base(new db_SCM()) {
            
        }


        /// <summary>
        /// 根据条件查询供货商表的信息并分页
        /// </summary>
        /// <param name="pname">供货商名字</param>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <returns></returns>
        public async Task<MyPage<ProductLend>> uponConditionPageForProductLend(string pname,int index = 1, int size = 3)
        {
            List<ProductLend> ls = null;
            await Task.Run(() =>
            {
                ls = base._db.ProductLend.ToList();
            });
            int total = ls.Count();
            if (!pname.Equals("输入名称"))
            {
                ls = ls.Where(x => x.PPName.Contains(pname)).ToList();
            }
            ls = ls.OrderBy(x => x.PPID).Skip((index - 1) * size).Take(size).ToList();
            return base.uponConditionPage<ProductLend>(ls, total);
        }
    }
}
