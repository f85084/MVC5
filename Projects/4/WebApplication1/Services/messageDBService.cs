using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;//引用Model命名空間

namespace WebApplication1.Services
{
    public class messageDBService
    {
        //實作資料庫模型
        public WebApplication1.Models.messageEntities db = new Models.messageEntities();

        //此方法取得資料庫中，Article資料表的資料並回傳
        public List<Article> GetData()
        {
            return (db.Article.ToList());
        }
        //此方法將接收的資料存入資料庫
        public void DBCreate(string Article_title, string Content)
        {
            //實作資料表Article
            Article NewData = new Article();
            NewData.Title = Article_title;//此變數用於儲存文章標題
            NewData.Content = Content;//此變數用於儲存內容標題
            NewData.time = DateTime.Now;//此變數用於儲存文章發表的時間

            //新增一筆資料
            db.Article.Add(NewData);
            //儲存資料庫變更
            db.SaveChanges();
        }
    }
}
