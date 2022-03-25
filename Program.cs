using System;
using System.Collections.Generic;

namespace cashierProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> ListUsers = FillCustomer();
            do
            {
                Customer UserLogged = Login(ListUsers);
                Menu(UserLogged);

            } while (true);
        }

        static List<Customer> FillCustomer()
        {
            List<Customer> ListUsers = new List<Customer>();
            
            Customer UserOne = new Customer("person1", "0000", 800);
            Customer UserTwo = new Customer("person2", "0000", 700);
            Customer UserThree = new Customer("person3", "0000", 600);
            Customer UserFour = new Customer("person4", "0000", 500);
            Customer UserFive = new Customer("person5", "0000", 400);
            Customer UserSix = new Customer("person6", "0000", 300);

            ListUsers.Add(UserOne);
            ListUsers.Add(UserTwo);
            ListUsers.Add(UserThree);
            ListUsers.Add(UserFour);
            ListUsers.Add(UserFive);
            ListUsers.Add(UserSix);

            return ListUsers;
            
        }

        static Customer Login(List<Customer> ListUsers)
        {
            Console.WriteLine("Por favor ingrese su username: ");
            string UserName = Console.ReadLine();
            bool ExistsUserName = ListUsers.Exists(item => item.CheckUserName() == UserName);

            if (ExistsUserName == true)
            {
                Console.WriteLine("Por favor ingrese su password: ");
                string Password = Console.ReadLine();
                bool CorrectPassword = ListUsers.Exists(item => item.CheckPassword() == Password && item.CheckUserName() == UserName);
                if (CorrectPassword == true)
                {
                    Customer Customer = ListUsers.Find(item => item.CheckUserName() == UserName);

                    if (Password == "0000")
                    {
                        Console.WriteLine("Por favor ingrese su nuevo password: ");
                        string NewPassword = Console.ReadLine();
                        
                        Customer.ChangePassword(NewPassword);
                        Console.WriteLine("Su contraseña ha sido cambiada exitosamente");
                        return Customer;

                    }

                    return Customer;

                }

                Console.WriteLine($"El password no es correcto");
                return null;

            } else
            {
                Console.WriteLine($"El usuario {UserName} no se encuentra registrado en el sistema");
                return null;
            }
        }

        static void Menu (Customer UserLogged)
        {
            if (UserLogged != null)
            {
                string OptionSelected;

                do
                {
                    Console.WriteLine("Menú de Usuario: ");
                    Console.WriteLine("1. Consultar Saldo Actual ");
                    Console.WriteLine("2. Retiro de Dinero ");
                    Console.WriteLine("3. Depositar Dinero");
                    Console.WriteLine("4. Cambiar Contraseña ");
                    Console.WriteLine("5. Cerrar Sesión");
                    Console.WriteLine("Seleccione la opción deseada: ");
                    OptionSelected = Console.ReadLine();

                    switch (OptionSelected)
                    {
                        case "1":
                            Console.WriteLine($"Su saldo actual es: {UserLogged.CheckMoney()}");
                            break;
                        case "2":
                            Console.WriteLine($"Cuanto dinero desea retirar: ");
                            string MoneyToWithdrawn = Console.ReadLine();
                            UserLogged.RemoveMoney(Convert.ToDecimal(MoneyToWithdrawn));
                            Console.WriteLine("Por favor retire su dinero");
                            break;
                        case "3":
                            Console.WriteLine($"Cuanto dinero desea depositar: ");
                            string MoneyToConsign = Console.ReadLine();
                            UserLogged.AddMoney(Convert.ToDecimal(MoneyToConsign));
                            Console.WriteLine("Su dinero ha sido consignado");
                            break;
                        case "4":
                            Console.WriteLine($"Ingrese su nueva contraseña: ");
                            string NewPassword = Console.ReadLine();
                            UserLogged.ChangePassword(NewPassword);
                            Console.WriteLine("Su contraseña ha sido actualizada");
                            break;
                        case "5":
                            Console.WriteLine($" Su sesión ha terminado ");
                            break;
                    }
                } while (OptionSelected != "5");
            }
        }
    }
}
