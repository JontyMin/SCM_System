using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM_System.UI.Views.Pdskc
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Assemble() {
            return View();
        }
    }
}