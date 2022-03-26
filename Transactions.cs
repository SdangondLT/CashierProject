using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Transactions
    {
        private int id { get; set; }
        private int idAccount { get; set; }
        private string description { get; set; }
        private DateTime dateOfTransactions  { get; set; }

        public Transactions(int idTransaction, int idAccount, string description, DateTime date)
        {
            this.id = idTransaction;
            this.idAccount = idAccount;
            this.description = description;
            this.dateOfTransactions = date;
        }
    }
}
