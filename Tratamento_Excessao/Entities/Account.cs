using System;
using System.Globalization;
using Tratamento_Excessao.Entities.Exceptions;

namespace Tratamento_Excessao.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithDrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {   
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance)
                throw new DomainExceptions ("Error: Insuficiente Balance.");
            else if(amount > WithDrawLimit)
                throw new DomainExceptions("Error: WithDraw Limit exceeded.");
            else
                Balance -= amount;
                Console.WriteLine("New Balance: $ " + Balance.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
