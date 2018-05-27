using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Guestbook.Models;

namespace Guestbook.Services
{
    public class GuestbooksDBService
    {
        //宣告資料庫實體模型物件
        MyGuestbookEntities db = new MyGuestbookEntities();

        //取得陣列資料方法
        public List<Guestbooks> GetDataList()
        {
            //回傳全部資料
            return db.Guestbooks.ToList();
        }

        #region 新增資料
        //新增資料方法
        public void InsertGuestbooks(Guestbooks newData)
        {
            //設定新增時間為現在
            newData.CreateTime = DateTime.Now;
            //將資料加入資料庫實體
            db.Guestbooks.Add(newData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 查詢一筆資料
        //藉由標號取得單筆資料的方法
        public Guestbooks GetDataById(int Id)
        {
            //回傳根據標號所取得的資料
            return db.Guestbooks.Find(Id);
        }
        #endregion

        #region 修改留言
        //修改留言方法
        public void UpdateGuestbooks(Guestbooks UpdateData)
        {
            //取得要修改的資料
            Guestbooks OldData = db.Guestbooks.Find(UpdateData.Id);
            //修改資料庫裡的值
            OldData.Name = UpdateData.Name;
            OldData.Content = UpdateData.Content;
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 回覆留言
        //回覆留言方法
        public void ReplyGuestbooks(Guestbooks ReplyData)
        {
            //取得要修改的資料
            Guestbooks OldData = db.Guestbooks.Find(ReplyData.Id);
            //設定回覆內容
            OldData.Reply = ReplyData.Reply;
            //設定回覆時間為現在
            OldData.ReplyTime = DateTime.Now;
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 檢查相關
        //修改資料判斷的方法
        public bool CheckUpdate(int Id)
        {
            //根據Id取得要修改的資料
            Guestbooks Data = db.Guestbooks.Find(Id);
            //判斷並回傳(判斷是否有資料以及是否有回覆)
            return (Data != null && Data.ReplyTime == null);
        }
        #endregion

        #region 刪除資料
        //刪除資料方法
        public void DeleteGuestbooks(int Id)
        {
            //根據Id取得要刪除的資料
            Guestbooks DeleteData = db.Guestbooks.Find(Id);
            //從資料庫實體中刪除資料
            db.Guestbooks.Remove(DeleteData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 查詢陣列資料
        //根據搜尋來取得資料陣列的方法
        public List<Guestbooks> GetDataList(string Search)
        {
            //宣告要接受全部搜尋資料的物件
            IQueryable<Guestbooks> SearchData;
            //判斷搜尋是否為空或Null，用於決定要呼叫取得搜尋資料
            if (String.IsNullOrEmpty(Search))
            {
                SearchData = db.Guestbooks;
            }
            else
            {
                SearchData = db.Guestbooks.Where(p => p.Name.Contains(Search)
|| p.Content.Contains(Search) || p.Reply.Contains(Search));
            }
            //先排序再根據分頁來回傳所需部分的資料陣列
            return SearchData.ToList();
        }
        #endregion
    }
}