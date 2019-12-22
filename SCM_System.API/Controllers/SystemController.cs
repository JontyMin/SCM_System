using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using SCM_System.DAL;
using SCM_System.IDAL;
using SCM_System.Model;
using SCM_System.Model.Jonty;

namespace SCM_System.API.Controllers
{
    [RoutePrefix("api/System")]
    public class SystemController : ApiController
    {
        BaseService<Model.Users> db = CreateFactory.CreateInstance<UsersService>();
        private readonly UsersService us = CreateFactory.CreateInstance<UsersService>();


        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user"></param>
        /// <returns>状态</returns>
        [HttpPost]
        [Route("UsersCheck")]
        public async Task<bool> UsersCheck(User user)
        {

            //查询员工是否存在
            var checkState = await us.LoginCheck(user);

            if (checkState)
            {
                //存在
                //是否勾选记住我
                if (user.UserLoginState)
                {
                    //cookie保存7天

                }
                else
                {
                    //session
                }

                return true;
            }
            else
            {
                //不存在，用户名或密码错误
                return false;
            }


        }



    }
}
