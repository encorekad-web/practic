using System;
public class Animal
{
    private string name;
    public string Name
    {
        get => name;
        set => name = value;
    }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издаёт звук.");
    }
}
public class Cat : Animal
{
    private int lives;
    public int Lives
    {
        get => lives;
        set
        {
            if (value >= 1 && value <= 9)
                lives = value;
            else
                Console.WriteLine("Количество жизней должно быть от 1 до 9!");
        }
    }
    public Cat(string name, int lives) : base(name)
    {
        Lives = lives;
    }
    public Cat(string name) : this(name, 9) { }
    public void Meow()
    {
        if (Lives > 1)
            Lives -= 1;
        Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
    }
}