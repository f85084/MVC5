using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "修改此範本即可開始著手進行您的 ASP.NET MVC 應用程式。";
            TempData["Message"] = "修改此範本即可開始著手進行您的 ASP.NET MVC 應用程式。";
            ViewData["Message"] = "修改此範本即可開始著手進行您的 ASP.NET MVC 應用程式。";
            return View();
        }

        public ContentResult ForContentResult()
        {
            return Content("這是ContentResult的回傳內容");
        }

        public EmptyResult ForEmptyResult()
        {
            return null;
        }

        public RedirectResult ForRedirectResult()
        {
            //重新導向至HomeController的Index
            return Redirect("~/Home/Index");
        }

        public RedirectToRouteResult ForRedirectToRouteResult()
        {
            //重新導向至HomeController的Index
            return RedirectToAction("Index", "Home", null);
        }

        public ViewResult ForViewResult()
        {
            return View();
        }

        public PartialViewResult ForPartialViewResult()
        {
            return PartialView();
        }
        
        public HttpUnauthorizedResult ForHttpUnauthorizedResult()
        {
            //假設未通過驗證，跳轉至Login
            return new HttpUnauthorizedResult();
        }

        public HttpNotFoundResult ForHttpNotFoundResult()
        {
            //回傳並定義狀態描述
            return HttpNotFound("Page No Found");
        }

        public JavaScriptResult ForJavaScriptResult()
        {
            string js = "alert(\"這是JavaScriptResult的結果\")";
            return JavaScript(js);
        }

        public JsonResult ForJsonResult()
        {
            var JsonContent = new
            {
                Id = 1,
                Content = "這是JsonResult的內容"
            };
            return Json(JsonContent, JsonRequestBehavior.AllowGet);
        }

        public FilePathResult ForFilePathResult()
        {
            //產生檔案路徑
            var imgPath = Server.MapPath("~/example.jpg");
            //回傳檔案
            return File(imgPath, "application/x-jpg");
        }

        public FileContentResult ForFileContentResult()
        {
            //使用Encoding將資料以UTF8編碼轉換成位元組
            //而使用Encoding需先引用System.Text
            byte[] data = Encoding.UTF8.GetBytes("此為FileContentResult的範例");
            //藉由File方法來回傳FileContentResult的使用參數為
            //File(byte[] 檔案資料, 檔案類型, 下載時檔案名稱)
            return File(data, "text/plain", "example.txt");
        }

        public FileStreamResult ForFileStreamResult()
        {
            //取得檔案路徑
            var path = Server.MapPath("~/File/example.txt");
            //使用FileStream將檔案開啟
            //而使用FileStream需先引用System.IO
            var fileStream = new FileStream(path, FileMode.Open);
            //藉由File方法來回傳FileStreamResult的使用參數為
            //File(FileStream, 檔案類型, 下載時檔案名稱)
            return File(fileStream, "text/plain", "example.txt");
        }

        public ActionResult ForActionResult()
        {
            if (new Random().Next() % 2 == 0) //這邊可替換成想要的判斷
                return View(); //回傳類似於ViewResult
            else
                return Json(null);//回傳類似於JsonResult
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