using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Message
    {
        [Key]
        public int Mid { get; set; }
        public string Name { get; set; }
    }
}