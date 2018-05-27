using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.ViewModels
{
    //商品資料頁面用ViewModel
    public class ItemDetailView
    {
        //新增商品內容
        public Item Data { get; set; }
        //是否在購物車中
        public bool InCart { get; set; }
    }
}