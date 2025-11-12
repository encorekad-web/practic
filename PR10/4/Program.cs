using System;
class Program
{
    static void Main()
    {
        Cat murzik = new Cat("Мурзик", 9);
        Cat barsik = new Cat("Барсик");
        murzik.Speak();
        barsik.Speak(); 
        murzik.Meow();
        barsik.Meow();
        murzik.Meow(); 
        barsik.Meow();
        Console.ReadLine();
    }
}