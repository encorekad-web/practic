using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount check = new CheckingAccount("CHTDS001", "Валера Озов", 2500, 500);
            SavingsAccount save = new SavingsAccount("BISD002", "Максим Смирнов ", 4000, 5);
            CreditAccount credit = new CreditAccount("ASD003", "Олег Соколов", -12000, 1000, new DateTime(2025, 11, 11));
            check.DisplayInfo();
            check.Withdraw(1300); 
            Console.WriteLine();
            save.DisplayInfo();
            save.AddInterest();  
            Console.WriteLine();
            credit.DisplayInfo();
            credit.MakePayment(1000);
        }
    }
}