using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BankAccount
{
    private decimal Balance { get; set; }

    public BankAccount(decimal startBalance)
    {
        Balance = startBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Пополнение выполнено успешно. Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: внесите положительное число.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Снято {amount}. Остаток: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: недостаточно средств или некорректная сумма.");
        }
    }
    public void Transfer(BankAccount target, decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            target.Balance += amount;
            Console.WriteLine($"Перечислено {amount} на целевой счёт. Ваш баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: неправильная сумма или нехватка средств.");
        }
    }
    public override string ToString()
    {
        return $"Баланс: {Balance}";
    }
}
class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount(10000);
        BankAccount account2 = new BankAccount(5000); 
        account1.Transfer(account2, 3000);
        Console.WriteLine($"Счет №1: {account1}");
        Console.WriteLine($"Счет №2: {account2}");
    }
}