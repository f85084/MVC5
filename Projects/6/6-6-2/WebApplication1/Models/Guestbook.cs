using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Guestbook
    {
        public int id { get; set; }

        [Required]
        [DisplayName("姓名：")]
        public string name { get; set; }

        [Required]
        [DisplayName("內容：")]
        public string content { get; set; }
    }
}