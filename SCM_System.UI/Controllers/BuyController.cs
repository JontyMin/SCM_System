using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCM_System.UI.Controllers
{
    public class BuyController : Controller
    {
        // GET: Buy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Depot()
        {
            return View();
        }

        public ActionResult DepotAdd()
        {
            return View();
        }

        public ActionResult DepotDetail()
        {
            return View();
        }

        public ActionResult DepotEdit()
        {
            return View();
        }

        public ActionResult PurchaseReturn()
        {
            return View();
        }

        public ActionResult PurchaseReturnAdd()
        {
            return View();
        }

        public ActionResult PurchaseReturnDetail()
        {
            return View();
        }
        public ActionResult PurchaseReturnEdit()
        {
            return View();
        }
        public ActionResult Reserve()
        {
            return View();
        }

        public ActionResult ReserveDetail()
        {
            return View();
        }

        public ActionResult Stocks()
        {
            return View();
        }

        public ActionResult StocksAdd()
        {
            return View();
        }

        public ActionResult StocksDetail(string sid)
        {
            ViewBag.sid = sid;
            return View();
        }

        public ActionResult StocksEdit()
        {
            return View();
        }
    }
}