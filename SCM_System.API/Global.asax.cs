using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace SCM_System.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        /// <summary>
        /// 跨域设置（预请求响应问题）
        /// </summary>
        protected void Application_BeginRequest()
        {
            //OPTIONS请求方法的主要作用（预请求，判断是否能够请求成功）：
            //用来检查服务器的性能。如：AJAX进行跨域请求时的预检，需要向另外一个域名的资源发送一个HTTP OPTIONS请求头，用以判断实际发送的请求是否安全。
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
            {
                //表示对输出的内容进行缓冲，执行page.Response.Flush()时，会等所有内容缓冲完毕，将内容发送到客户端。
                //这样就不会出错，造成页面卡死状态，让用户无限制的等下去
                Response.Flush();
            }
        }
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
