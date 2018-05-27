using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class GuestbookDB
    {
        GuestbookEntities db = new GuestbookEntities();

        public void Create(string name, string content)
        {
            //新增一筆Content資料物件
            Contents NewData = new Contents();
            //設定新增的值
            NewData.name = name;
            NewData.content = name;
            //將資料加入Content資料表中
            db.Contents.Add(NewData);
            //儲存資料度變更
            db.SaveChanges();
        }

        //新增資料
        public void Create(Contents NewData)
        {
            //將資料加入Contnet資料表中
            db.Contents.Add(NewData);
            //儲存資料庫變更
            db.SaveChanges();
        }

        //修改資料
        public bool Update(int id, string name, string content)
        {
            //取得編號的資料
            Contents Data = db.Contents.Find(id);
            //判斷是否有資料
            if (Data != null)
            {
                //修改資料的值
                Data.name = name;
                Data.content = content;
                //儲存資料度變更
                db.SaveChanges();
                return true;
            }
            else
            {
                return false; //回傳失敗
            }
        }

        //修改資料
        public bool Update(Contents UpdateData)
        {
            //取得編號的資料
            Contents Data = db.Contents.Find(UpdateData.Id);
            //判斷是否有資料
            if (Data != null)
            {
                //修改資料的值
                Data.name = UpdateData.name;
                Data.content = UpdateData.content;
                //儲存資料庫的變更
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;//回傳失敗
            }
        }

        //刪除資料
        public bool Delete(int id)
        {
            //取得編號的資料
            Contents DeleteData = db.Contents.Find(id);
            //判斷是否有資料
            if (DeleteData != null)
            {
                //將資料從Content資料表中移除
                db.Contents.Remove(DeleteData);
                //儲存資料並變更
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;//回傳失敗
            }
        }

        //取得所有資料
        public List<Contents> GetList()
        {
            //取得Content資料表的資料，並轉成List
            List<Contents> ContentList = db.Contents.ToList();
            //回傳List資料
            return ContentList;
        }

        //取得單一編號資料
        public Contents GetContent(int id)
        {
            //取得的資料
            Contents Data = db.Contents.Find(id);
            //回傳資料
            return Data;
        }
    }
}