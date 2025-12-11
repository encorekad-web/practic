using System;

public struct Color
{
    public int R;
    public int G;
    public int B;

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}
class Program
{
    static void Main()
    {
        var c1 = new Color(255, 128, 0);
        var c2 = c1;

        c2.R = 100;

        Console.WriteLine(c1); 
        Console.WriteLine(c2);
    }
}