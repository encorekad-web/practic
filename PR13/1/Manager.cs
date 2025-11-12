using ConsoleApp23;
using System;
using System.Xml.Linq;

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, decimal salary, DateTime hireDate, int teamSize)
        : base(name, "Менеджер", salary, hireDate)
    {
        TeamSize = teamSize;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Размер команды: " + TeamSize);
    }

    public void HoldMeeting()
    {
        Console.WriteLine(Name.Trim() + " проводит собрание с командой из " + TeamSize + " человек.");
    }
}