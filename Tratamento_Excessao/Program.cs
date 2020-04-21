using System;
using System.Globalization;
using Tratamento_Excessao.Entities;
using Tratamento_Excessao.Entities.Exceptions;

namespace Tratamento_Excessao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: $ ");
                double initBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: $ ");
                double wdLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: $ ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initBalance, wdLimit);
                acc.WithDraw(amount);
                Console.ReadLine();
            }
            catch (DomainExceptions err)
            {
                Console.WriteLine(err.Message);
                Console.ReadLine();
            }
            catch (Exception err)
            {
                Console.WriteLine("Unexpected error: " + err.Message);
                Console.ReadLine();
            }
        }
    }
}
