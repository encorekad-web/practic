using System;
class Program
{
    static void Main()
    {
        var obj1 = new ObjectCounter();
        var obj2 = new ObjectCounter();
        var obj3 = new ObjectCounter();
        ObjectCounter.PrintObjectCount();
        Console.ReadLine();
    }
}