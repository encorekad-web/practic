using System;

class Program
{
    static void Main()
    {
        Calculator.Sum(5, 3);
        Calculator.Sub(10, 4);
        Calculator.Mul(7, 6);      
        Calculator.Div(10, 2);
        Calculator.Div(10, 0);  
        Console.ReadLine();
    }
}