using System;
public class Point
{
    private double x;
    private double y;
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point(double value) : this(value, value) { }
    public Point() : this(0, 0) { }
    public void Show()
    {
        Console.WriteLine($"Точка: ({X}, {Y})");
    }
}