using System;
using System.Collections.Generic;

namespace cashierProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> listUsers = FillCustomer();
            do
            {
                Customer UserLogged = Login(listUsers);
                Menu(UserLogged);

            } while (true);
        }

        static List<Customer> FillCustomer()
        {
            List<Customer> listUsers = new List<Customer>();
            
            Customer userOne = new Customer("davis", "0000", 5800);
            Customer userTwo = new Customer("paulina", "0000", 6700);
            Customer userThree = new Customer("silena", "0000", 5600);
            Customer userFour = new Customer("sebastian", "0000", 4500);
            Customer userFive = new Customer("dolcey", "0000", 1400);
            Customer userSix = new Customer("jhonny", "0000", 1900);
            Customer userSeven = new Customer("mariana", "0000", 8800);
            Customer userEight = new Customer("santiago", "0000", 3800);
            Customer userNine = new Customer("dayana", "0000", 6800);
            Customer userTen = new Customer("roberto", "0000", 2800);
            Customer userEleven = new Customer("isabela", "0000", 1800);

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

        static Customer Login(List<Customer> listUsers)
        {
            Console.Write("Por favor ingrese su usuario: ");
            string userName = Console.ReadLine();
            bool existsUserName = listUsers.Exists(item => item.CheckUserName() == userName);

            if (existsUserName == true)
            {
                Console.Write("Por favor ingrese su clave: ");
                string password = Console.ReadLine();
                bool correctPassword = listUsers.Exists(item => item.CheckPassword() == password && item.CheckUserName() == userName);
                if (correctPassword == true)
                {
                    Customer customer = listUsers.Find(item => item.CheckUserName() == userName);

                    if (password == "0000")
                    {
                        Console.Write("Por favor ingrese su nueva clave: ");
                        string newPassword = Console.ReadLine();

                        customer.ChangePassword(newPassword);
                        Console.WriteLine("Su clave ha sido cambiada exitosamente");
                        return customer;

                    }

                    return customer;

                }

                Console.WriteLine($"El password no es correcto");
                return null;

            } else
            {
                Console.WriteLine($"El usuario {userName} no se encuentra registrado en el sistema");
                return null;
            }
        }

        static void Menu (Customer UserLogged)
        {
            if (UserLogged != null)
            {
                string optionSelected = String.Empty;

                do
                {
                    Console.WriteLine("Menú de Usuario: ");
                    Console.WriteLine("1. Consultar Saldo Actual ");
                    Console.WriteLine("2. Retiro de Dinero ");
                    Console.WriteLine("3. Depositar Dinero");
                    Console.WriteLine("4. Cambiar Contraseña ");
                    Console.WriteLine("5. Cerrar Sesión");
                    Console.Write("Seleccione la opción deseada: ");
                    optionSelected = Console.ReadLine();

                    switch (optionSelected)
                    {
                        case "1":
                            Console.WriteLine($"Su saldo actual es: {UserLogged.CheckMoney()}");
                            break;
                        case "2":
                            Console.WriteLine($"Cuanto dinero desea retirar: ");
                            string moneyToWithdrawn = Console.ReadLine();
                            UserLogged.RemoveMoney(Convert.ToDecimal(moneyToWithdrawn));
                            Console.WriteLine("Por favor retire su dinero");
                            break;
                        case "3":
                            Console.WriteLine($"Cuanto dinero desea depositar: ");
                            string moneyToConsign = Console.ReadLine();
                            UserLogged.AddMoney(Convert.ToDecimal(moneyToConsign));
                            Console.WriteLine("Su dinero ha sido consignado");
                            break;
                        case "4":
                            Console.WriteLine($"Ingrese su nueva contraseña: ");
                            string newPassword = Console.ReadLine();
                            UserLogged.ChangePassword(newPassword);
                            Console.WriteLine("Su contraseña ha sido actualizada");
                            break;
                        case "5":
                            Console.WriteLine($" Su sesión ha terminado ");
                            break;
                    }
                } while (optionSelected != "5");
            }
        }
    }
}
