using System;

public class Phone
{
    private int _battery;
    public string Brand { get; init; }
    public int BatteryLevel
    {
        get => _battery;
        private set
        {
            if (value >= 0 && value <= 100)
                _battery = value;
            else
                Console.WriteLine("Заряд не может превышать 100%!");
        }
    }
    public Phone(string brand, int initialBattery)
    {
        Brand = brand;
        BatteryLevel = initialBattery; 
    }
    public void Use()
    {
        _battery -= 10;
        if (_battery < 0)
            _battery = 0;
        Console.WriteLine($"{Brand}: заряд {_battery}%");
    }
}