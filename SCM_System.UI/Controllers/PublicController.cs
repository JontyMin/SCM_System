using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM_System.UI.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerPage() {
            return View();
        }


        public ActionResult ProductsAll() {
            return View();
        }

        public ActionResult CustomerOrderPage() {
            return View();
        }

        public ActionResult DepostProducts() {
            return View();
        }


        public ActionResult Supplier() {
            return View();
        }

        public ActionResult QuotePricepage() {
            return View();
        }
    }
}