using System;

public class Employee
{
    private string name;
    private decimal salary;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal Salary
    {
        get 
        { 
            return salary; 
        }
        set
        {
            if (value >= 0 && value <= 1000000)
                salary = value;
            else
                Console.WriteLine("Зарплата должна быть от 0 до 1 000 000!");
        }
    }
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
    public Employee(string name) : this(name, 50000) { } 
    public void Work()
    {
        Console.WriteLine($"{Name} работает, зарплата: {Salary}");
    }
}