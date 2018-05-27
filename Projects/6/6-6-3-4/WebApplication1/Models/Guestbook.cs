using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Guestbook
    {
        public int id { get; set; }
        public string Content { get; set; }
        public DateTime CreaTime { get; set; }

        public ICollection<Member> Member { get; set; }
    }

    public class Member
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Guestbook> Guestbooks { get; set; }
    }
}