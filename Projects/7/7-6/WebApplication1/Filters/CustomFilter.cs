using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Filters
{
    public class CustomFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //定義顯示資訊的訊息
            string message = string.Format("一名使用者於{0}時，進入{1}的{2} Action",
            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            filterContext.Controller,
            filterContext.RouteData.Values["action"] as String);

            //輸出訊息至偵錯輸出的視窗中
             System.Diagnostics.Debug.WriteLine(message, "Action Filter Log");
        }
    }
}