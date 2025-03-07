using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atestat.Models
{
    public class TransactionModel
    {
        public int TransactionID { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public string TransactionType { get; set; }  // e.g. "Expense" / "Income"
        public int CategoryID { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
    }
}
