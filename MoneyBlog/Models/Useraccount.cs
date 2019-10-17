using System;
using System.Collections.Generic;

namespace MoneyBlog.Models
{
    public partial class Useraccount
    {
        public int UserId { get; set; }
        public int? AccountId { get; set; }
        public string UserRole { get; set; }
    }
}
