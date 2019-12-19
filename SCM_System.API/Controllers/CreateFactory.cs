using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM_System.DAL;
using SCM_System.IDAL;

namespace SCM_System.API.Controllers
{
    public  class CreateFactory
    {
        private static Dictionary<string,object> dic=new Dictionary<string, object> () ;
        public static T CreateInstance<T>() where T:class
        {
            #region 同一个页面无论实例多少个相同的dal都是一个dal
            //string str = HttpContext.Current.Request.Url.ToString();
            //str = str.Substring(str.IndexOf("api"));
            //string name = typeof(T).Name;
            //if (!dic.ContainsKey(str+"_"+name))
            //{
            //    T t = (T)Activator.CreateInstance<T>();
            //    dic.Add(str + "_" + name,t);
            //    return t;
            //}
            //return (T)dic[str + "_" + name];
            #endregion

            #region 不同的页面无论实例多少个相同的dal都是一个dal
            string name = typeof(T).Name;
            if (!dic.ContainsKey(name))
            {
                T t = (T)Activator.CreateInstance<T>();
                dic.Add(name, t);
                return t;
            }
            return (T)dic[name];
            #endregion

        }
    }
}