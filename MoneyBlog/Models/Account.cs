using System;
using System.Collections.Generic;

namespace MoneyBlog.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public int? AccountNumber { get; set; }
        public decimal? Balance { get; set; }
        public string AccountType { get; set; }
        public string AccountName { get; set; }
    }
}
