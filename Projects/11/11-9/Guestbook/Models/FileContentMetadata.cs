using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guestbook.Models
{
    //定義FileContent資料表的驗證
    [MetadataType(typeof(FileContentMetadata))]
    public partial class FileContent
    {
        private class FileContentMetadata
        {
            [DisplayName("編號")]
            public int Id { get; set; }

            [DisplayName("檔名")]
            public string Name { get; set; }

            [DisplayName("路徑")]
            public string Url { get; set; }

            [DisplayName("大小(Byte)")]
            public int Size { get; set; }

            [DisplayName("新增時間：")]
            public DateTime CreateTime { get; set; }
        }
    }

}