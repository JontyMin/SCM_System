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
        /// <summary>
        /// 创建dal的实例,如需创建模型的类请用CreateInstanceModal
        /// </summary>
        /// <typeparam name="T">dal中的类型</typeparam>
        /// <returns></returns>
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


        /// <summary>
        /// 创建模型类（注意：如果一个模型类实例为单例，那么就算再次给参数赋值为false也无效）
        /// </summary>
        /// <typeparam name="T">模型中的类型</typeparam>
        /// <param name="isSingle">是否为单例(如果此类在需求中有且只有一个就可用单例,默认为false)</param>
        /// <returns></returns>
        public static T CreateInstanceModel<T>(bool isSingle=false) where T:Model.BaseEntity {
            string name = typeof(T).Name;
            if (dic.ContainsKey(name) || isSingle)
            {
                if (!dic.ContainsKey(name))
                {
                    T t = (T)Activator.CreateInstance<T>();
                    dic.Add(name, t);
                    return t;
                }
                return (T)dic[name];
            }
            return (T)Activator.CreateInstance<T>();            
        }
    }
}