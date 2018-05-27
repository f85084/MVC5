using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;


namespace WebApplication1.Controllers
{
    public class MessageController : Controller
    {
        //實作Service的物件
        messageDBService data = new messageDBService();

        public ActionResult Index()
        {
            //將資料傳回View
            return View(data.GetData());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Article_title, string Content)
        {
            //呼叫Service中的DBCreate方法
            data.DBCreate(Article_title, Content);
            //導向至指定的Action
            return RedirectToAction("Index");
        }
    }
}