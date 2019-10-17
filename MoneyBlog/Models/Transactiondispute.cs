using System;
using System.Collections.Generic;

namespace MoneyBlog.Models
{
    public partial class Transactiondispute
    {
        public int DisputeId { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? Time { get; set; }
        public string Description { get; set; }
    }
}
