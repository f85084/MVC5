using Guestbook.Models;
using Guestbook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guestbook.ViewModels
{
    //檔案管理頁面用ViewModel
    public class FileView
    {
        //儲存得檔案陣列
        public List<FileContent> FileList { get; set; }
        //分頁內容
        public ForPaging Paging { get; set; }
    }

}