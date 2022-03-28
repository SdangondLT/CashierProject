using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashierProject
{
    internal class ATM
    {
        public int id { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public Bank bank { get; set; }


        public ATM(int idATM, string descriptionATM, string status, Bank bank)
        {
            this.id = idATM;
            this.description = descriptionATM;
            this.status = status;
            this.bank = bank;
        }

        public bool Login(int idAccountReceived, string password)
        {            
            bool userValidated = bank.ValidateUser(idAccountReceived, password);

            if (userValidated == true)
            { 
                if(password == "0000")
                {
                    Console.Write("Por favor ingrese su nueva clave para ser actualizada: ");
                    string newPassword = Console.ReadLine();

                    bank.ChangePassword(idAccountReceived, newPassword);
                    Console.WriteLine("Su clave ha sido actualizada exitosamente");
                    
                }

                return true;  

            } else
            {

                return false;   

            }
        }

        public void Menu()
        {
            Console.Write("Por favor ingrese su número de cuenta: ");
            int idAccountReceived = int.Parse(Console.ReadLine());
            Console.Write("Por favor ingrese su clave: ");
            string password = Console.ReadLine();

            if (Login(idAccountReceived, password) == true)
            {
                string optionSelected = String.Empty;

                do
                {
                    Console.WriteLine("\n************************************************");
                    Console.WriteLine($"                Bienvenido a {bank.name}");
                    Console.WriteLine("\n************************************************");
                    Console.WriteLine("  Opciones Bancarias: ");
                    Console.WriteLine("\n************************************************");
                    Console.WriteLine("  1. Consultar Saldo Actual ");
                    Console.WriteLine("  2. Retiro de Dinero ");
                    Console.WriteLine("  3. Depositar Dinero");
                    Console.WriteLine("  4. Cambiar Contraseña ");
                    Console.WriteLine("  5. Revision de transacciones");
                    Console.WriteLine("  6. Cerrar Sesión");
                    Console.WriteLine("\n************************************************");
                    Console.Write(" Seleccione la opción deseada: ");
                    optionSelected = Console.ReadLine();

                    switch (optionSelected)
                    {
                        case "1":
                            Console.WriteLine("\n************************************************");
                            Console.WriteLine($"Su saldo actual es: {bank.CurrentMoney(idAccountReceived)}");
                            break;
                        case "2":
                            Console.WriteLine($"Cuanto dinero desea retirar: ");
                            int moneyToWithdrawn = int.Parse(Console.ReadLine());
                            bank.WithDrawalMoney(idAccountReceived, moneyToWithdrawn);
                            Console.WriteLine("Por favor retire su dinero del cajero");
                            break;
                        case "3":
                            Console.WriteLine($"Cuanto dinero desea depositar: ");
                            int moneyToConsign = int.Parse(Console.ReadLine());
                            bank.AddMoney(idAccountReceived, moneyToConsign);
                            Console.WriteLine("Su dinero ha sido consignado");
                            break;
                        case "4":
                            Console.WriteLine($"Ingrese su nueva contraseña: ");
                            string newPassword = Console.ReadLine();
                            bank.ChangePassword(idAccountReceived, newPassword);
                            Console.WriteLine("Su contraseña ha sido actualizada");
                            break;
                        case "5":
                            Console.WriteLine($" Revision de transacciones ");
                            bank.ShowTransactions(idAccountReceived);
                            break;
                        case "6":
                            Console.WriteLine($" Su sesión ha terminado ");
                            break;
                    }
                    
                } while (optionSelected != "6");
            }
        }
    }
}
