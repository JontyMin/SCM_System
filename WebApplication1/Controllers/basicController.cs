using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM_System.UI.Controllers
{
    public class BasicController : Controller
    {
        // GET: basic
        public ActionResult Index()
        {
            return View();
        }
    }
}