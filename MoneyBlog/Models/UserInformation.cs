using System;
using System.Collections.Generic;

namespace MoneyBlog.Models
{
    public partial class UserInformation
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
