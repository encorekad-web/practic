using System;

class Device
{
    protected string _brand;
    public string Brand { get => _brand; set => _brand = value; }
    public Device(string brand)
    {
        Brand = brand;
    }

    public virtual void PowerOn()
    {
        Console.WriteLine($"{Brand} включен.");
    }
}
class Laptop : Device
{
    private int _ram;
    public int Ram
    {
        get => _ram;
        set
        {
            if (value >= 1 && value <= 64)
                _ram = value;
            else
                Console.WriteLine("ОЗУ должно быть от 1 до 64!");
        }
    }
    private int _battery;
    public int Battery
    {
        get => _battery;
        set
        {
            if (value >= 0 && value <= 100)
                _battery = value;
            else
                Console.WriteLine("Заряд батареи должен быть от 0 до 100%!");
        }
    }
    public Laptop(string brand, int ram, int battery) : base(brand)
    {
        Ram = ram;
        Battery = battery;
    }
    public override void PowerOn()
    {
        base.PowerOn();
    }
    public void Work()
    {
        Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
    }
}