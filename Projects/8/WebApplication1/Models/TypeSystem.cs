using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TypeSystem
    {
        [EmailAddress]
        public string email { get; set; }

        public string name { get; set; }
    }
}
