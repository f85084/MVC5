using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Services
{
    public class ItemService
    {
        //宣告資料庫實體模型物件
        private ShoppingEntities db = new ShoppingEntities();

        #region 取得資料相關
        #region 取得單一商品資料
        //藉由編號取的單筆商品資料的方法
        public Item GetDataById(int Id)
        {
            //回傳根據標號所取得的資料
            return db.Item.Find(Id);
        }
        #endregion

        #region 取得商品編號陣列
        public List<int> GetIdList(ForPaging Paging)
        {
            //取得資料庫中的Item資料表
            IQueryable<Item> Data = db.Item;
            //計算所需的總頁面
            Paging.MaxPage = Convert.ToInt32(Math.Ceiling(
                Convert.ToDouble(Data.Count()) / Paging.ItemNum));
            //重新設定正確的頁數，避免有不正確值傳入
            Paging.SetRightPage();
            //先排序再根據分頁來回傳所需的部分資料陣列
            return Data.OrderByDescending(p => p.Id)
                .Skip((Paging.NowPage - 1) * Paging.ItemNum).Take(Paging.ItemNum)
                .Select(p => p.Id).ToList();
        }
        #endregion
        #endregion

        #region 新增商品
        //新增商品方法
        public void Insert(Item newData)
        {
            //將資料加入資料庫實體
            db.Item.Add(newData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 刪除商品
        //刪除商品方法
        public void Delete(int Id)
        {
            //根據Id取得要刪除的資料
            Item DeleteData = db.Item.Find(Id);
            List<CartBuy> DeleteCartBuyList = DeleteData.CartBuy.ToList();
            //刪除購物車裡的商品
            foreach (CartBuy Delete in DeleteCartBuyList)
            {
                db.CartBuy.Remove(Delete);
            }
            //先儲存變更，以便能刪除商品
            db.SaveChanges();
            //從資料庫實體中刪除資料
            db.Item.Remove(DeleteData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion
    }
}