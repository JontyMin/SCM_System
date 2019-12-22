using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Jonty
{

    /// <summary>
    /// 登录接收
    /// </summary>
   public class User
    {
        public string UserLoginName { get; set; }

        public string UserLoginPwd { get; set; }

        public bool UserLoginState { get; set; }
    }
}
