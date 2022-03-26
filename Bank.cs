using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Account> accounts { get; set; }
        public List<User> users { get; set; }

        public Bank(int idBank, string nameBank, List<Account> accounts, List<User> users)
        {
            this.id = idBank;
            this.name = nameBank;
            this.accounts = accounts;
            this.users = users;
        }

        public bool ValidateUser(int idAccount, string password)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int idUser = accountFound.idUser;
            User userFound = users.Find(item => item.idUser == idUser);
            string passwordOfUserFound = userFound.password;

            if (passwordOfUserFound == password)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public int CurrentMoney(int idAccount)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int balance = accountFound.balance;
            return balance;
        }
        public void AddMoney(int idAccount, int moneyToSave)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int balance = accountFound.balance;
            accountFound.balance = balance + moneyToSave;
        }

        public void WithDrawalMoney(int idAccount, int moneyToWithdraw)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int balance = accountFound.balance;
            accountFound.balance = balance - moneyToWithdraw;
        }
        public void ChangePassword(int idAccount, string newPassword)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int idUserOfAccountFound = accountFound.idUser;
            User userFound = users.Find(item => item.idUser == idUserOfAccountFound);
            userFound.password = newPassword;
        }
    }
}
