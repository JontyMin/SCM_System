using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.DAL.PageClass
{
    public static class PageFrozen
    {
        public static MyPage<T> customPage<T>(this DbContext db, string mainkey, int index = 1, int size = 3) where T : class
        {
            var ls = db.Set<T>().OrderBy(x => "x." + mainkey).Skip((index - 1) * size).Take(size).ToList();
            var total = db.Set<T>().Count();
            MyPage<T> list = new MyPage<T>()
            {
                ls = ls,
                total = total
            };
            return list;
        }
    }

    public class MyPage<T>
    {
        public int total { get; set; }
        public List<T> ls { get; set; }
    }
}
