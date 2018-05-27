using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Services
{
    public class CartService
    {
        //宣告資料庫實體模型物件
        private ShoppingEntities db = new ShoppingEntities();

        #region 查詢相關
        #region 取得購物車內商品陣列
        //取得於購物車內的商品陣列
        public List<CartBuy> GetItemFromCart(string Cart)
        {
            //根據購物車編號取得已放入購物車的商品陣列
            return db.CartBuy.Where(p => p.Cart_Id == Cart).ToList();
        }
        #endregion

        #region 確認商品是否於購物車中
        //確認商品是否於購物車中方法
        public bool CheckInCart(string Cart, int Item_Id)
        {
            //根據購物車與商品編號取得CartBuy資料表內資料
            CartBuy SearchData = db.CartBuy
                .Where(p => p.Cart_Id == Cart && p.Item_Id == Item_Id)
                .FirstOrDefault();
            //判斷使否有資料，以確認是否於購物車中
            return (SearchData != null);
        }
        #endregion

        #region 確認購物車是否有保存
        //確認商品是否於購物車中方法
        public bool CheckCartSave(string user, string Cart)
        {
            //根據會員帳號與購物車編號取得CartSave資料表內資料
            CartSave SearchData = db.CartSave
                .Where(p => p.Account == user && p.Cart_Id == Cart)
                .FirstOrDefault();
            //判斷使否有資料，以確認是否於購物車中
            return (SearchData != null);
        }
        #endregion

        #region 取得購物車保存
        //取得購物車保存方法
        public string GetCartSave(string user)
        {
            //根據會員帳號取得CartSave資料表內資料
            CartSave SearchData = db.CartSave
                .Where(p => p.Account == user).FirstOrDefault();
            //判斷使否有資料，以確認是否於購物車中
            if (SearchData != null)
            {
                return SearchData.Cart_Id;
            }
            else
            {
                return null;
            }
        }
        #endregion
        #endregion

        #region 放入購物車
        //將商品放入購物車方法
        public void AddtoCart(string Cart, int Item_Id)
        {
            //宣告一筆新的CartBuy資料表資料物件
            CartBuy newData = new CartBuy();
            //設定資料的值
            newData.Cart_Id = Cart;
            newData.Item_Id = Item_Id;
            //將資料加入資料庫實體
            db.CartBuy.Add(newData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 從購物車取出
        //將商品從購物車取出方法
        public void RemoveForCart(string Cart, int Item_Id)
        {
            //根據購物車與商品編號取得CartBuy資料表內資料
            CartBuy DeleteData = db.CartBuy
                .Where(p => p.Cart_Id == Cart && p.Item_Id == Item_Id)
                .FirstOrDefault();
            //從資料庫實體中刪除資料
            db.CartBuy.Remove(DeleteData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 保存購物車
        public void SaveCart(string user, string Cart)
        {
            //宣告一筆新的CartSave資料表資料物件
            CartSave newData = new CartSave();
            //設定資料的值
            newData.Account = user;
            newData.Cart_Id = Cart;
            //將資料加入資料庫實體
            db.CartSave.Add(newData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion

        #region 取消保存購物車
        public void SaveCartRemove(string user)
        {
            //根據會員帳號與購物車編號取得CartSave資料表內資料
            CartSave DeleteData = db.CartSave
                .Where(p => p.Account == user).FirstOrDefault();
            //從資料庫實體中刪除資料
            db.CartSave.Remove(DeleteData);
            //儲存資料庫變更
            db.SaveChanges();
        }
        #endregion
    }
}