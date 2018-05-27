using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Guestbook.Models;
using System.ComponentModel;

namespace Guestbook.ViewModels
{
    public class GuestbookView
    {
        //搜尋欄位
        [DisplayName("搜尋：")]
        public string Search { get; set; }
        //顯示資料陣列
        public List<Guestbooks> DataList { get; set; }
    }
}