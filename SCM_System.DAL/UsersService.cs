using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM_System.Model;
using SCM_System.Model.Jonty;

namespace SCM_System.DAL
{

    public class UsersService : BaseService<Users>
    {
        public UsersService() : base(new db_SCM())
        {
        }


        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="user">数据</param>
        /// <returns>bool</returns>
        public async Task<bool> LoginCheck(User user)
        {
            return await base._db.Users.AnyAsync(c =>
                c.UserLoginName == user.UserLoginName && c.UserLoginPwd == user.UserLoginPwd);
        }
    }

}
