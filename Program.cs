using System;
using System.Collections.Generic;

namespace cashierProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = ATMBankTech();
            atm.Menu();
        }

        static Bank BankTech()
        {
            Bank banktech = new Bank(10, "Bank Tech", AccountOfUsers(), FillUsers());
            return banktech;
        }
        //public ATM(int idATM, string descriptionATM, string status, Bank bank)
        static ATM ATMBankTech()
        {
            ATM ATMBankTech = new ATM(45, "Cajero 24 horas de Bank Tech", "active", BankTech());
            return ATMBankTech;
        }
        static List<User> FillUsers()
        {
            List<User> listUsers = new List<User>();

            User userOne = new User(1,"davis", "carrera 15 # 89-65", "0000", "active");
            User userTwo = new User(2, "paulina", "carrera 15 # 89-65", "0000", "active");
            User userThree = new User(3, "silena", "carrera 15 # 89-65", "0000", "active");
            User userFour = new User(4, "sebastian", "carrera 15 # 89-65", "0000", "active");
            User userFive = new User(5, "dolcey", "carrera 15 # 89-65", "0000", "inactive");
            User userSix = new User(6, "jhonny", "carrera 15 # 89-65", "0000", "inactive");
            User userSeven = new User(7, "mariana", "carrera 15 # 89-65", "0000", "inactive");
            User userEight = new User(8, "santiago", "carrera 15 # 89-65", "0000", "active");
            User userNine = new User(9, "dayana", "carrera 15 # 89-65", "0000", "active");
            User userTen = new User(10, "roberto", "carrera 15 # 89-65", "0000", "inactive");
            User userEleven = new User(11, "isabela", "carrera 15 # 89-65", "0000", "inactive");

            listUsers.Add(userOne);
            listUsers.Add(userTwo);
            listUsers.Add(userThree);
            listUsers.Add(userFour);
            listUsers.Add(userFive);
            listUsers.Add(userSix);
            listUsers.Add(userSeven);
            listUsers.Add(userEight);
            listUsers.Add(userNine);
            listUsers.Add(userTen);
            listUsers.Add(userEleven);

            return listUsers;

        }
        static List<Account> AccountOfUsers()
        {
            List<Account> listAccount = new List<Account>();

            Account accountOne = new Account(1234, "current", "active", 4005, 1);
            Account accountTwo = new Account(5678, "savings", "active", 2505, 2);
            Account accountThree = new Account(9874, "savings", "inactive", 8005, 3);
            Account accountFour = new Account(5632, "savings", "active", 7005, 4);
            Account accountFive = new Account(1597, "savings", "active", 1000, 5);
            Account accountSix = new Account(7532, "current", "active", 8575, 6);
            Account accountSeven = new Account(9654, "current", "inactive", 4685, 7);
            Account accountEight = new Account(8541, "current", "inactive", 9875, 8);
            Account accountNine = new Account(9654, "savings", "active", 7455, 9);
            Account accountTen = new Account(7863, "savings", "active", 6785, 10);
            Account accountEleven = new Account(8523, "savings", "active", 4877, 11);

            listAccount.Add(accountOne);
            listAccount.Add(accountTwo);
            listAccount.Add(accountThree);
            listAccount.Add(accountFour);
            listAccount.Add(accountFive);
            listAccount.Add(accountSix);
            listAccount.Add(accountSeven);
            listAccount.Add(accountEight);
            listAccount.Add(accountNine);
            listAccount.Add(accountTen);
            listAccount.Add(accountEleven);

            return listAccount;

        }
    }
}
