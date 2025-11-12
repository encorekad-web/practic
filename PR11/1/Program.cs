class Program
{
    static void Main()
    {
        var phone = new Phone("Samsung", 80);
        phone.UseMultipleTimes(3);
        phone.BatteryLevel = 150;
        Console.ReadLine()
    }
}