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
        public List<Transactions> listTransaction { get; set; }
        public List<Account> accounts { get; set; }
        public List<User> users { get; set; }

        public Bank(int idBank, string nameBank, List<Transactions> listTransaction, List<Account> accounts, List<User> users)
        {
            this.id = idBank;
            this.name = nameBank;
            this.listTransaction = listTransaction;
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
            Transactions transactions = new Transactions(listTransaction.Count + 1, idAccount, "Revision de saldo actual", DateTime.Now );
            listTransaction.Add(transactions);
            return balance;
        }
        public void AddMoney(int idAccount, int moneyToSave)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int balance = accountFound.balance;
            accountFound.balance = balance + moneyToSave;
            Transactions transactions = new Transactions(listTransaction.Count + 1, idAccount, "Consignacion de dinero", DateTime.Now);
            listTransaction.Add(transactions);
        }

        public void WithDrawalMoney(int idAccount, int moneyToWithdraw)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int balance = accountFound.balance;
            accountFound.balance = balance - moneyToWithdraw;
            Transactions transactions = new Transactions(listTransaction.Count + 1, idAccount, "Retiro de saldo", DateTime.Now);
            listTransaction.Add(transactions);
        }
        public void ChangePassword(int idAccount, string newPassword)
        {
            Account accountFound = accounts.Find(item => item.id == idAccount);
            int idUserOfAccountFound = accountFound.idUser;
            User userFound = users.Find(item => item.idUser == idUserOfAccountFound);
            userFound.password = newPassword;
            Transactions transactions = new Transactions(listTransaction.Count + 1, idAccount, "Cambio de contraseña", DateTime.Now);
            listTransaction.Add(transactions);
        }

        public void ShowTransactions(int idAccount)
        {
            List<Transactions> transactionFound = listTransaction.FindAll(item => item.idAccount == idAccount);
            foreach (var item in transactionFound)
            {
                Console.WriteLine($"{ item.description} - {item.dateOfTransactions}" );
            }
        }
    }
}
