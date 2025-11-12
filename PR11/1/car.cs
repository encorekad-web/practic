using System;

public class Car
{
    private int speed;
    public int Speed
    {
        get { return speed; }
        set
        {
            if (value >= 0 && value <= 300)
            {
                speed = value;
            }
            else
            {
                Console.WriteLine("Скорость не может превышать 300!");
            }
        }
    }
    
    public string Model { get; set; } = "Unknown";
    public Car(string model, int speed)
    {
        Model = model;
        Speed = speed;
    }
    public void Drive()
    {
        Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
    }
}
