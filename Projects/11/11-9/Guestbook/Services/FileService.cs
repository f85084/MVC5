using Guestbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guestbook.Services
{
    public class FileService
    {
        //宣告資料庫實體模型物件
        MyFileEntities db = new MyFileEntities();

        #region 上傳檔案
        public void UploadFile(string FileName, string Url, int Size, string Type)
        {
            //宣告新FileContent資料表資料
            FileContent newFile = new FileContent();
            //設定內容
            newFile.Name = FileName;
            newFile.Url = Url;
            newFile.Size = Size;
            newFile.Type = Type;
            newFile.CreateTime = DateTime.Now;
            //新增至資料庫中
            db.FileContent.Add(newFile);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 取得檔案陣列
        //取得分頁檔案資料陣列方法
        public List<FileContent> GetFileList(ForPaging Paging)
        {
            //設定要接受全部搜尋資料的物件
            IQueryable<FileContent> SearchData = GetAllFileList(Paging);
            //先排序再根據分頁來回傳所需的部分資料陣列
            return SearchData.OrderByDescending(p => p.Id)
                .Skip((Paging.NowPage - 1) *
                    Paging.ItemNum).Take(Paging.ItemNum).ToList();
        }
        //搜尋全部檔案資料與設定分頁內容方法
        public IQueryable<FileContent> GetAllFileList(ForPaging Paging)
        {
            //宣告要回傳的搜尋資料為資料庫中的FileContent資料表
            IQueryable<FileContent> Data = db.FileContent;
            //計算所需的總頁面
            Paging.MaxPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(
                Data.Count()) / Paging.ItemNum));
            //重新設定正確的頁數，避免有不正確值傳入
            Paging.SetRightPage();
            //回傳搜尋資料
            return Data;
        }
        #endregion

        #region 取得單一檔案資料
        //取得單一檔案資料路徑方法
        public FileContent GetFileContent(int Id)
        {
            //根據傳入編號取得檔案資料
            FileContent GetFile = db.FileContent.Find(Id);
            //回傳資料
            return GetFile;
        }
        #endregion

    }
}