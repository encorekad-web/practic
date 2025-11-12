using System;
public class Player
{
    private int level;
    private int health;
    public string Name { get; init; }
    public int Level
    {
        get => level;
        set
        {
            if (value >= 1 && value <= 100)
                level = value;
            else
                Console.WriteLine("Уровень должен быть от 1 до 100!");
        }
    }
    public int Health
    {
        get => health;
        set
        {
            if (value >= 0 && value <= 100)
                health = value;
            else
                Console.WriteLine("Здоровье должно быть от 0 до 100!");
        }
    }
    public bool IsAlive => health > 0;
    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
        StatusReport();
    }
    private void StatusReport()
    {
        Console.WriteLine(
            $"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {IsAlive}"
        );
    }
}