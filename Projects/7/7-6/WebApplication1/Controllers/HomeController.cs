using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult TestAction(string Content)
        {
            ViewData["Content"] = Content;

            return View();
        }*/

        /*public ActionResult TestAction(FormCollection form)
        {
            ViewData["Content"] = form["Content"];

            return View();
        }*/

        /*public ActionResult TestAction(TestFormModel form)
        {
            ViewData["Content"] = form.Content;
            ViewData["UserId"] = form.UserId;

            return View();
        }*/

        /*public ActionResult TestAction(TestFormModel form)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "未通過驗證！";
                return View();
            }
            else
            {
                ViewData["Message"] = "已通過驗證！";
                ViewData["Content"] = form.Content;
                ViewData["UserId"] = form.UserId;

                return View();
            }
        }*/

       /* public ActionResult TestAction(TestFormModel form)
        {
            if(!ModelState.IsValid)
            {
                ViewData["Message"] = "未通過驗證！";
                return View();
            }
            else
            {
                form.Time = DateTime.Now;
                ViewData["Message"] = "已通過驗證！";
                ViewData["Content"] = form.Content;
                ViewData["UserId"] = form.UserId;
                ViewData["Time"] = form.Time;

                return View();
            }
        }*/

        /*public ActionResult TestAction(TestFormModel form)
        {
            UpdateModel<TestFormModel>(form);
            return Redirect("/");
        } */

        public ActionResult TestAction(TestFormModel form)
        {
            if (!TryUpdateModel<TestFormModel>(form))
            {
                ViewData["Message"] = "模型連結失敗!";
                return View();
            }
            return Redirect("/");
        }

        [RequireHttps]//限定此Action必定以HTTPS通訊限定進行連線
        public ActionResult SecretPage()
        {
            return View();
        }

        //取消驗證表單資料，或讓有HTML標籤的內容通過
        [ValidateInput(false)]
        public ActionResult Edit(FormCollection form)
        {
            //處理程式片段
            return View();
        }

        [OutputCache(Duration = 30)]
        public ActionResult outputcache()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }


        /*//限制ForDelete Action只能由Tony使用
        [Authorize(Users = "Tony")]
        public ActionResult ForDelete()
        {
            return View();
        }*/

        /*//這樣角色名為SuperUser的使用者，都可使用此Action
        [Authorize(Roles = "SuperUser")]
        public ActionResult Delete()
        {
            return View();
        }*/

        [ChildActionOnly] //此Action只能被當作子系統動作呼叫
        public ActionResult ForPartialView()
        {
            return PartialView();
        }


        [CustomFilter]
        public ActionResult Index()
        {
            return View();
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


