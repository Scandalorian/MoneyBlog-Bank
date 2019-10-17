using System;
using System.Collections.Generic;

namespace MoneyBlog.Models
{
    public partial class Accounttransaction
    {
        public int TransactionId { get; set; }
        public int? AccountId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Time { get; set; }
        public string Recipient { get; set; }
    }
}
