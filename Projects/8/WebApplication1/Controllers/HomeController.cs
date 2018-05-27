using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestAction1()
        {
            return View();
        }

        public ActionResult TestAction2()
        {
            TestModel data = new TestModel();
            data.txtRemember = "記住我";
            return View(data);
        }

        public ActionResult HelpAction()
        {
            return View();
        }

        public ActionResult PartialText()
        {
            return PartialView();
        }

        public PartialViewResult ForChildAction()
        {
            return PartialView();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}