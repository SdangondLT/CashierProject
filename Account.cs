using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Account
    {
        public int id { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public int balance { get; set; }
        public int idUser { get; set; }

        public Account(int idAccount, string typeAccount, string status, int balance, int idUser)
        {
            this.id = idAccount;
            this.type = typeAccount;
            this.status = status;
            this.balance = balance;
            this.idUser = idUser;
        }
        
    }
}
