using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Customer
    {
        private string userName { get; set; }
        private string password { get; set; }
        private decimal currentMoney { get; set; }

        public Customer(string userName, string password, decimal currentMoney)
        {
            this.userName = userName;
            this.password = password;
            this.currentMoney = currentMoney;
        }

        public void ChangePassword(string newPassword)
        {
            this.password = newPassword;
        }

        public decimal CheckMoney()
        {
            return currentMoney;
        }

        public string CheckUserName()
        {
            return userName;
        }

        public string CheckPassword()
        {
            return password;
        }

        public void AddMoney(decimal addedMoney)
        {
            this.currentMoney = this.currentMoney + addedMoney;
        }

        public void RemoveMoney(decimal moneyWithdrawn)
        {
            this.currentMoney = this.currentMoney - moneyWithdrawn;
        }
    }
}
