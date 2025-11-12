using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    public class BankAccount
    {
        private string owner;
        private double balance;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Баланс не может быть отрицательным!");
                    balance = 0;
                }
                else
                {
                    balance = value;
                }
            }
        }

        public BankAccount(string owner, double initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{Owner}, баланс: {Balance}.");
            }
            else
            {
                Console.WriteLine("Сумма депозита должна быть больше 0!");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"{Owner}, баланс: {Balance}.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств!");
                    Console.WriteLine($"{Owner}, баланс: {Balance}.");
                }
            }
            else
            {
                Console.WriteLine("Сумма снятия должна быть больше 0!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Иван", 1000);

            account.Deposit(500);

            account.Withdraw(500);

            account.Withdraw(2000);

            Console.ReadKey();
        }
    }
}