using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM_System.DAL;
using SCM_System.IDAL;

namespace SCM_System.API.Controllers
{
    public class CreateFactory
    {
        public static T CreateInstance<T>() 
        {
            return Activator.CreateInstance<T>();
        }
    }
}