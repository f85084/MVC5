using Guestbook.Models;
using Guestbook.Services;
using Guestbook.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbook.Controllers
{
    public class FileController : Controller
    {
        FileService fileService = new FileService();
        #region 首頁
        //一開始載入Action，並設定初始頁數為1
        public ActionResult Index(int Page = 1)
        {
            //宣告一個新頁面模型
            FileView Data = new FileView();
            //新增頁面模型中的分頁
            Data.Paging = new ForPaging(Page);
            //從Service中取得頁面所需陣列資料
            Data.FileList = fileService.GetFileList(Data.Paging);
            //將頁面資料傳入View中
            return View(Data);
        }
        #endregion

        #region 上傳檔案
        //上傳檔案用的Action
        [HttpPost] //設定此Action只接受頁面POST資料傳入
        public ActionResult UploadFile(HttpPostedFileBase upload)
        {
            //檢查是否有上傳檔案
            if (upload != null)
            {
                //取得檔名
                string filename = Path.GetFileName(upload.FileName);
                //將檔案和伺服器上路徑合併
                string Url = Path.Combine(Server.MapPath("~/Upload/")
                    , filename);
                //將檔案儲存於伺服器上
                upload.SaveAs(Url);
                //藉由Service將檔案資料存入資料庫
                fileService.UploadFile(upload.FileName, Url, upload.ContentLength
                    , upload.ContentType);
            }
            //重新導向頁面至開始頁面
            return RedirectToAction("Index");
        }
        #endregion

        #region 下載檔案
        //下載檔案用Action
        public ActionResult DownloadFile(int Id)
        {
            //取得下載檔案內容資料
            FileContent Download = fileService.GetFileContent(Id);
            //判斷是否有資料
            if (Download != null)
            {
                //將檔案讀成串流
                Stream iStream = new FileStream
                    (Download.Url, FileMode.Open, FileAccess.Read, FileShare.Read);
                //回傳出檔案
                return File(iStream, Download.Type, Download.Name);
            }
            else
            {
                return JavaScript("alert(\"無此檔案\")");
            }
        }
        #endregion

    }
}