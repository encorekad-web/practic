using System;

public class ProgramConfig
{
    public const string Version = "1.0";
    public const string Developer = "Иван Иванов";
    public static void DisplayInfo()
    {
        Console.WriteLine($"Версия программы: {Version}");
        Console.WriteLine($"Разработчик: {Developer}");
    }
}