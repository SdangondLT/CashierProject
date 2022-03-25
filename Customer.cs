using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Customer
    {
        private string UserName { get; set; }
        private string Password { get; set; }
        private decimal CurrentMoney { get; set; }
        public Customer(string UserName, string Password, decimal CurrentMoney)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.CurrentMoney = CurrentMoney;
        }

        public void ChangePassword(string NewPassword)
        {
            this.Password = NewPassword;
        }
        public decimal CheckMoney()
        {
            return CurrentMoney;
        }
        public string CheckUserName()
        {
            return UserName;
        }
        public string CheckPassword()
        {
            return Password;
        }
        public void AddMoney(decimal AddedMoney)
        {
            this.CurrentMoney = this.CurrentMoney + AddedMoney;
        }
        public void RemoveMoney(decimal MoneyWithdrawn)
        {
            this.CurrentMoney = this.CurrentMoney - MoneyWithdrawn;
        }
    }
}
