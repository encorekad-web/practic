using System;
public class Calc
{
    public static void Sum(double n1, double n2)
    {
        Console.WriteLine(n1 + n2);
    }
    public static void Sub(double n1, double n2)
    {
        Console.WriteLine(n1 - n2);
    }
    public static void Mul(double n1, double n2)
    {
        Console.WriteLine(n1 * n2);
    }
    public static void Div(double n1, double n2)
    {
        if (n2 != 0)
        {
            Console.WriteLine(n1 / n2);
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль!");
        }
    }
}