using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TestModel
    {
        [Required(ErrorMessage = "請輸入使用者名稱")]
        [Display(Name = "使用者名稱：")]
        public string txtId { get; set; }

        [Required(ErrorMessage = "請輸入密碼")]
        [Display(Name = "密碼：")]
        public string txtPasswd { get; set; }

        public bool Remeber { get; set; }
        public string txtRemember { get; set; }
    }
}