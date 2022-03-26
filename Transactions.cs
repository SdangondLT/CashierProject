using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Transactions
    {
        public int id { get; set; }
        public int idAccount { get; set; }
        public string description { get; set; }
        public DateTime dateOfTransactions  { get; set; }

        public Transactions(int idTransaction, int idAccount, string description, DateTime date)
        {
            this.id = idTransaction;
            this.idAccount = idAccount;
            this.description = description;
            this.dateOfTransactions = date;
        }
    }
}
