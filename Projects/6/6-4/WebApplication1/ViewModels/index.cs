using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class index
    {
        [DisplayName("必選修")]
        public string required { get; set; }

        /*[Required(ErrorMessage = "學生姓名不得空白")]
        public string name { get; set; }

        [StringLength(10, ErrorMessage = "學生姓名不得超過10字元")]
        public string name { get; set; }*/

        [StringLength(10, ErrorMessage = "學生姓名必須介於2-10字元", MinimumLength = 2)]
        public string name { get; set; }

        [Range(0, 100, ErrorMessage = "得分必須介於0~100之間")]
        public int point { get; set; }

        [System.Web.Mvc.Compare("re_password", ErrorMessage = "兩次密碼輸入不一致")]
        public string password { get; set; }
        public string re_password { get; set; }

        [RegularExpression( @"^[0-9]{2,4}-?[0-9]{3,4}-?[0-9]{-4}$", ErrorMessage = "請輸入正確的電話號碼")]
        public string phone { get; set;}

        [EmailAddress(ErrorMessage = "這不是E-mail格式")]
        public string studentmail { get; set; }

        [Url(ErrorMessage = "這不是網址標準格式")]
        public string url { get; set; }

        [FileExtensions(ErrorMessage = "所上傳檔案不是圖片")]
        public string file { get; set; }

        [CreditCard(ErrorMessage = "這不是信用卡格式")]
        public string creditCard { get; set; }

        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [Remote("RemoteTest", "Home", ErrorMessage = "Remote屬性測試")]
        public string For_Remore { get; set; }

    }

    [MetadataType(typeof(ContentMetaData))]
    public partial class Content
    {
        private class ContentMetaData
        {
            [DisplayName("編號")]
            public int Id { get; set; }

            [DisplayName("姓名")]
            [Required(ErrorMessage = "請輸入姓名")]
            [StringLength(10, ErrorMessage = "姓名不得超過10字元")]
            public string name { get; set; }

            [DisplayName("內容")]
            [Required(ErrorMessage = "請輸入內容")]
            public string content { get; set; }
        }
    }
}